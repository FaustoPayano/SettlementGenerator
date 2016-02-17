using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace SettlementGenerator.Model {
    public class SettlementMemo {
        public SettlementMemo() {
            Application application = new Application();
            Document document =
                application.Documents.Open(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,
                    "Settlement Memo Template C Sharp.docx"));

            StringBuilder sbBuilder = new StringBuilder();
            int count = document.Words.Count;
            for (int i = 1; i <= count; i++) {
                sbBuilder.Append(document.Words[i].Text + " ");
            }
            MessageBox.Show(sbBuilder.ToString());
        }

    }

}
