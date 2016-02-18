using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Office.Interop.Word;
using Novacode;
using System = Microsoft.Office.Interop.Word.System;

namespace SettlementGenerator.Model {
    public class SettlementMemo {
        public SettlementMemo() {
            using (
                DocX memoTemplate =
                    DocX.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        "TestTemplate.docx"))) {
                StringBuilder contents = new StringBuilder();
                int count = 0;
                for(int i = 0; i < memoTemplate.Paragraphs.Count; i++)
                {
                    contents.Append(memoTemplate.Paragraphs[i].Text + "\n");
                }
                MessageBox.Show(contents.ToString());
            }
        }

    }

}
