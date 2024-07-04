using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VulnHunt
{
    public class CMD
    {
        private static Process process;
        private static StringBuilder _commandOutput;
        private bool outputDataCompleted = false;
        private RichTextBox richText;
        private string output;
        public CMD(RichTextBox richTextBox)
        {
            richText = richTextBox;
        }
        public void RunAsync()
        {
         
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = @"c:\",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "kali",
                RedirectStandardOutput = true,
            RedirectStandardError = true,
            RedirectStandardInput = true,
                UseShellExecute = false
            };
            Process p = new Process();
            p.StartInfo = startInfo;
            p.OutputDataReceived += p_OutputDataReceived;
            p.ErrorDataReceived += p_ErrorDataReceived;

            p.Start();
            _ = p.WaitForExitAsync();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.StandardInput.WriteLine("msfconsole\n");
            p.StandardInput.WriteLine();
            Thread.Sleep(9000);
            p.StandardInput.WriteLine("search windows\n");
            p.StandardInput.WriteLine();
        }
        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
            {
                outputDataCompleted = true;
            }
            else
            {
                // Invoke the update on the UI thread
                richText.Invoke((MethodInvoker)delegate {
                    // 1. Determine the encoding of the e.Data input
                    Encoding encoding = Encoding.UTF8; // Assuming the input is UTF-8 encoded

                    // 2. Convert the e.Data to a string using the appropriate encoding
                    string inputText = encoding.GetString(encoding.GetBytes(e.Data));

                    // 3. Split the input text into lines
                    string[] lines = inputText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    // 4. Append the lines to the RichTextBox, preserving the formatting
                    foreach (string line in lines)
                    {
                        // Check if the line contains formatting characters
                        if (line.Contains("[32m") || line.Contains("[45m") || line.Contains("[0m"))
                        {
                            // Apply the formatting using RichTextBox's formatting capabilities
                            richText.SelectionStart = richText.TextLength;
                            richText.SelectionLength = 0;

                            // Set the formatting based on the detected tags
                            if (line.Contains("[32m"))
                            {
                                richText.SelectionColor = Color.Green;
                            }
                            else if (line.Contains("[45m"))
                            {
                                richText.SelectionColor = Color.Purple;
                            }
                            else if (line.Contains("[0m"))
                            {
                                richText.SelectionColor = richText.ForeColor;
                            }

                            richText.SelectedText = line.Replace("[32m", "").Replace("[45m", "").Replace("[0m", "") + Environment.NewLine;
                        }
                        else
                        {
                            // Append the line without any formatting
                            richText.AppendText(line + Environment.NewLine);
                        }
                    }
                });
            }
        }



        void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("Received from standard error: " + e.Data);
        }
    }
}