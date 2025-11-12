using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.IO;

namespace KossanVMS.Utility
{
    public class GatePass
    {
        public bool GenerateGatePass()
        {
            var model = new Gatepass
            {
                CenterName = "Research and Development Center",
                GateTag = "KI-C014",
                Number = "G0000010455",
                Company = "HIGH TINES",
                VisitorName = "HO EEYONG",
                IcNo = "98/206105370",
                PersonToVisit = "MR VICTOR",
                Purpose = "Meeting",
                Date = DateTime.Parse("2025-07-29"),
                TimeIn = DateTime.Parse("10:06:33 AM"),
                TimeOut = null,
                VehicleNo = "",
                DONo = "",
                TelNo = "0123133087"
            };

            var doc = BuildDocument(model);
            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = doc;
            renderer.RenderDocument();

            PdfDocument pdf = renderer.PdfDocument;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "gatepass.pdf");

            pdf.Save(path);
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
            return true;
        }

        Document BuildDocument(Gatepass m)
        {
            var doc = new Document();
            var style = doc.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 10;

            var sec = doc.AddSection();
            sec.PageSetup.PageFormat = PageFormat.A5;
            sec.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
            sec.PageSetup.TopMargin = Unit.FromMillimeter(10);
            sec.PageSetup.BottomMargin = Unit.FromMillimeter(10);
            sec.PageSetup.LeftMargin = Unit.FromMillimeter(10);
            sec.PageSetup.RightMargin = Unit.FromMillimeter(10);

            // Main container table
            var mainTable = sec.AddTable();
            mainTable.Borders.Width = 1;
            
            mainTable.Borders.Color = Colors.Black;

            // Columns: Left (Visitor Info) | Middle (Date/Time) | Right (Office Use)
            mainTable.AddColumn(Unit.FromMillimeter(100));  // Left column
            mainTable.AddColumn(Unit.FromMillimeter(100));  // Middle column  
         //  mainTable.AddColumn(Unit.FromMillimeter(60));  // Right column

            // ===== ROW 1: Header =====
            var row1 = mainTable.AddRow();
            row1.Height = Unit.FromMillimeter(25);
            row1.Cells[0].MergeRight = 1;
            // Right: Tag 
            row1.TopPadding = Unit.FromMillimeter(2);
            row1.BottomPadding = Unit.FromMillimeter(1);
            var tagHeader = row1.Cells[0].AddParagraph();
            tagHeader.AddFormattedText(m.GateTag + "\n", TextFormat.Underline);
            tagHeader.Format.Font.Size = 12;
            tagHeader.Format.Alignment = ParagraphAlignment.Center;
        
            // Left: Center Name + Gate Pass
            var mainHeader = row1.Cells[0].AddParagraph();
            mainHeader.AddFormattedText(m.CenterName + "\n", TextFormat.Bold);
            mainHeader.Format.Font.Size = 12;
            mainHeader.AddFormattedText("Gate Pass", TextFormat.Bold);
            mainHeader.Format.Font.Size = 14;
            mainHeader.Format.Alignment = ParagraphAlignment.Center;

            var gatePassNo = row1.Cells[0].AddParagraph();
            gatePassNo.AddFormattedText(m.Number + "\n", TextFormat.Underline);
            gatePassNo.Format.Font.Size = 12;
            gatePassNo.Format.Alignment = ParagraphAlignment.Center;
            // Middle: Empty
            row1.Cells[1].AddParagraph("");

           

            // ===== ROW 2: Visitor Information =====
            var row2 = mainTable.AddRow();
            row2.Height = Unit.FromMillimeter(20);
            row2.Cells[0].Borders.Right.Width = 0;
            row2.Cells[1].Borders.Left.Width = 0;
            // Left: Visitor Details
            var leftColumn = new Table();
            leftColumn.Borders.Width = 0;
           
            leftColumn.AddColumn(Unit.FromMillimeter(45)); // Labels
            leftColumn.AddColumn(Unit.FromMillimeter(45)); // Values
            var spaceRowTop = leftColumn.AddRow();
            spaceRowTop.TopPadding = Unit.FromMillimeter(2);
            spaceRowTop.BottomPadding = Unit.FromMillimeter(2);
            AddDetailRow(leftColumn, "COMPANY", m.Company);
            AddDetailRow(leftColumn, "VISITOR'S NAME", m.VisitorName);
            AddDetailRow(leftColumn, "I.C. NO.", m.IcNo);
            AddDetailRow(leftColumn, "PERSON TO VISIT", m.PersonToVisit);
            AddDetailRow(leftColumn, "PURPOSE OF VISIT", m.Purpose);
            var spaceRowBottom = leftColumn.AddRow();
            spaceRowBottom.TopPadding = Unit.FromMillimeter(2);
            spaceRowBottom.BottomPadding = Unit.FromMillimeter(2);

            row2.Cells[0].Elements.Add(leftColumn);

            // Middle: Date/Time Section
            var rightColumn = new Table();
            rightColumn.Borders.Width = 0;
            rightColumn.AddColumn(Unit.FromMillimeter(45)); // Labels
            rightColumn.AddColumn(Unit.FromMillimeter(45)); // Values

            //var dateTitleRow = rightColumn.AddRow();
            //dateTitleRow.Cells[0].MergeRight = 1;
            //dateTitleRow.Cells[0].AddParagraph("Date").Format.Font.Bold = true;
            //dateTitleRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            //AddDetailRow(rightColumn, "", "");
            spaceRowTop = rightColumn.AddRow();
            spaceRowTop.TopPadding = Unit.FromMillimeter(2);
            spaceRowTop.BottomPadding = Unit.FromMillimeter(2);
            AddDetailRow(rightColumn, "DATE", m.Date.ToString("M/d/yyyy"));
            AddDetailRow(rightColumn, "TIME IN", m.TimeIn.ToString("hh.mm.ssTT").ToLower());
            AddDetailRow(rightColumn, "TIME OUT", m.TimeOut?.ToString("hh.mm.ssTT").ToLower() ?? "");
            AddDetailRow(rightColumn, "VEHICLE NO.", m.VehicleNo);
            AddDetailRow(rightColumn, "D/O NO.", m.DONo);
            AddDetailRow(rightColumn, "TEL NO.", m.TelNo);
            spaceRowBottom = rightColumn.AddRow();
            spaceRowBottom.TopPadding = Unit.FromMillimeter(2);
            spaceRowBottom.BottomPadding = Unit.FromMillimeter(2);

            row2.Cells[1].Elements.Add(rightColumn);

            //// down: Office Use Section
            //var downTable = new Table();
            //downTable.Borders.Width = 0;
            //downTable.AddColumn(Unit.FromMillimeter(60)); // Full width

            //var officeTitleRow = downTable.AddRow();
            //officeTitleRow.Cells[0].AddParagraph("OFFICE USE").Format.Font.Bold = true;
            //officeTitleRow.Cells[0].Format.Alignment = ParagraphAlignment.Center;

            //AddOfficeField(downTable, "NAME");
            //AddOfficeField(downTable, "SIGNATURE");
            //AddOfficeField(downTable, "REMARKS", 20);

            //row2.Cells[2].Elements.Add(downTable);

            // ===== ROW 3: Time Out Section =====
            var row3 = mainTable.AddRow();
            row3.Height = Unit.FromMillimeter(35);

            // Span all columns for time out
            row3.Cells[0].MergeRight = 1;
            var officeUseTable = new Table();
            officeUseTable.Borders.Width = 0;
            officeUseTable.AddColumn(Unit.FromMillimeter(25));
            officeUseTable.AddColumn(Unit.FromMillimeter(145)); // Remaining width
            //AddDetailRow(rightColumn, "", "");
            //AddDetailRow(rightColumn, "", "");
            var officeUseRowTitle = officeUseTable.AddRow();
            officeUseRowTitle.TopPadding = Unit.FromMillimeter(2);
            officeUseRowTitle.BottomPadding = Unit.FromMillimeter(2);
            officeUseRowTitle.Cells[0].AddParagraph("OFFICE USE").Format.Font.Bold = true;
            //AddDetailRow(rightColumn, "", "");
            //AddDetailRow(rightColumn, "", "");
            var officeUseRowName = officeUseTable.AddRow();
            officeUseRowName.BottomPadding = Unit.FromMillimeter(1);
            officeUseRowName.TopPadding = Unit.FromMillimeter(1);

            officeUseRowName.Cells[0].AddParagraph("NAME:").Format.Font.Bold = true;
            officeUseRowName.Cells[1].Borders.Bottom.Width = 0.5;

            var officeUseRowSignature = officeUseTable.AddRow();
            officeUseRowSignature.TopPadding = Unit.FromMillimeter(1);
            officeUseRowSignature.BottomPadding = Unit.FromMillimeter(1);
            officeUseRowSignature.Cells[0].AddParagraph("SIGNATURE:").Format.Font.Bold = true;
            officeUseRowSignature.Cells[1].Borders.Bottom.Width = 0.5;
            var officeUseRowTimeOut = officeUseTable.AddRow();
            officeUseRowTimeOut.TopPadding = Unit.FromMillimeter(1);
            officeUseRowTimeOut.BottomPadding = Unit.FromMillimeter(1);
            officeUseRowTimeOut.Cells[0].AddParagraph("TIME OUT:").Format.Font.Bold = true;
            officeUseRowTimeOut.Cells[1].Borders.Bottom.Width = 0.5;
            //AddDetailRow(rightColumn, "", "");
            //AddDetailRow(rightColumn, "", "");
            //  timeOutRow.Cells[1].AddParagraph(":");
            
            var officeUseRowRemarks = officeUseTable.AddRow();
            officeUseRowRemarks.TopPadding = Unit.FromMillimeter(1);
            officeUseRowRemarks.BottomPadding = Unit.FromMillimeter(2);
            officeUseRowRemarks.Cells[0].AddParagraph("REMARKS:").Format.Font.Bold = true;
            officeUseRowRemarks.Cells[1].Borders.Bottom.Width = 0.5;
            //AddDetailRow(rightColumn, "", "");
            //AddDetailRow(rightColumn, "", "");
            //  timeOutRow.Cells[1].AddParagraph(":");
         
            row3.Cells[0].Elements.Add(officeUseTable);

            return doc;
        }

        private void AddDetailRow(Table table, string label, string value)
        {
            var row = table.AddRow();
            row.TopPadding = Unit.FromMillimeter(1);
            row.BottomPadding = Unit.FromMillimeter(1);
            row.Cells[0].AddParagraph(label).Format.Font.Bold = true;
            
            row.Cells[1].AddParagraph(": " + value);
        }

        private void AddOfficeField(Table table, string label, double height = 12)
        {
            var row = table.AddRow();
            row.Height = Unit.FromMillimeter(height);

            var innerTable = new Table();
            innerTable.Borders.Width = 0;
            innerTable.AddColumn(Unit.FromMillimeter(20)); // Label
            innerTable.AddColumn(Unit.FromMillimeter(40)); // Underline

            var innerRow = innerTable.AddRow();
            innerRow.Cells[0].AddParagraph(label).Format.Font.Bold = true;
            innerRow.Cells[1].Borders.Bottom.Width = 0.5;
            innerRow.Cells[1].AddParagraph(""); // Empty for underline

            row.Cells[0].Elements.Add(innerTable);
        }
    }

    public class Gatepass
    {
        public string CenterName { get; set; } = "";
        public string GateTag { get; set; } = "";
        public string Number { get; set; } = "";
        public string Company { get; set; } = "";
        public string VisitorName { get; set; } = "";
        public string IcNo { get; set; } = "";
        public string PersonToVisit { get; set; } = "";
        public string Purpose { get; set; } = "";
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string VehicleNo { get; set; } = "";
        public string DONo { get; set; } = "";
        public string TelNo { get; set; } = "";
    }
}