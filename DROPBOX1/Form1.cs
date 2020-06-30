using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dropbox.Api.Files;
using Dropbox.Api.Sharing;
using Dropbox;
using Dropbox.Api;

using System.IO.Compression;


namespace DROPBOX1
{
    public partial class Form1 : Form
    {
        static string token = "";
        static string data;
        static string diretorioPadrao = @"c:\\NovasDlls";
        static string diretorioExtrair = @"c:\\";
        static string statusLog = "";
        static string file = "dlls.zip";
        static string arquivoParaUpload = "";
        static Double porcentagem; 
        public Form1()
        {
            InitializeComponent();

            txtValueDirectory.Text = diretorioPadrao;
            lblStatus.Text = "";
            txtDirectoryExtratorsFiles.Text = diretorioExtrair;


        }

       

        //-----------------------------------------------------------------------------------------------------------
        // metodo para baixar os arquivos da api
        private void btnBaixarFile(object sender, EventArgs e)
        {
            progressBar2.MarqueeAnimationSpeed = 30;
            progressBar2.Style = ProgressBarStyle.Marquee;
            groupBox2.Controls.Add(progressBar2);

            try
            {
                if (txtValueDirectory.Text.ToString().Length != 0)
                {
                    var task = Task.Run((Func<Task>)Form1.Baixar);
                    task.Wait();

                    if (task.IsCompleted)
                    {
                        progressBar2.Dispose();
                        lblStatus.Text = "Arquivo baixado!";
                        txtFileExtracted.Text = diretorioPadrao + @"\" + data + @"\" + file;
                        MessageBox.Show("Arquivo baixado com sucesso!");
                    }
                    else
                    {
                        progressBar2.Dispose();
                        lblStatus.Text = "Falha ao baixar arquivo";
                        MessageBox.Show("Falha ao baixar arquivo, verifique sua internet.");
                    }
                }
                else
                {
                    progressBar2.Dispose();
                    MessageBox.Show("Selecione a pasta de destino");
                }

            }
            catch (Exception ex)
            {
                progressBar2.Dispose();
                lblStatus.Text = "Arquivo inexistente ou Sem conexão com a Internet!";
                MessageBox.Show("Arquivo inexistente ou Sem conexão com a Internet!"+ex);
            }
        }

        static async Task Baixar()
        {
           
                var dbx = new DropboxClient(token);
                data = DateTime.Now.ToString("yyyy-MM-dd HHmmss");
                Directory.CreateDirectory(diretorioPadrao + @"\" + data);

                string folderApi = "/dlls";
               
                var tempFile = diretorioPadrao + @"\" + data + @"\" + file;

              //  const int bufferSize = 1024 * 1024;
              //  var buffer = new byte[bufferSize];
               // ulong fileSize;


                var response = await dbx.Files.DownloadAsync(folderApi + "/" + file);
                ulong fileSize = response.Response.Size;
                const int bufferSize = 1024 * 1024;
                var buffer = new byte[bufferSize];
                
                using (var stream = await response.GetContentAsStreamAsync())
                {
                    using (var localfile = new FileStream(tempFile, FileMode.OpenOrCreate))
                    {
                        var length = stream.Read(buffer, 0, bufferSize);

                    
                     // Form1.progressBar2.Value = 25;


                    while (length > 0)
                        {
                            localfile.Write(buffer, 0, length);
                            var percentage = 100 * (ulong)localfile.Length / fileSize;


                            Console.WriteLine(percentage);
                        
                            length = stream.Read(buffer, 0, bufferSize);
                        }
                      
                    }
             


                /*
                                using (var response = await dbx.Files.DownloadAsync(folderApi + "/" + file))
                                {


                                    var s = response.GetContentAsByteArrayAsync();
                                    s.Wait();
                                    var d = s.Result;
                                   fileSize = response.Response.Size;

                                    using (var fileStream = File.Create(tempFile))
                                    {

                                        var stream = await response.GetContentAsStreamAsync();
                                        var length = stream.Read(buffer, 0, bufferSize);
                                        fileStream.Write(buffer, 0, length);

                                        var percentage = 100 * (ulong)fileStream.Length / fileSize;

                                            Console.WriteLine(percentage);


                                        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                                    }

                                    File.WriteAllBytes(file, d);

                                }
                        */
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            

            string tempFile = txtFileExtracted.Text;
           
            var Diretorio = txtDirectoryExtratorsFiles.Text;

            Console.WriteLine(Diretorio);
            try
            {
                if (System.IO.Directory.Exists(Diretorio))
                {
                    if (System.IO.File.Exists(tempFile))
                    {
                        try
                        {
                            using (ZipArchive archive = ZipFile.OpenRead(tempFile))
                            {
                                prgContador.Minimum = 0;
                                prgContador.Maximum = archive.Entries.Count;

                                int x = 0;
                                listBox1.Items.Clear();
                                lblStatus.Text = "";
                                lblTotalExtracted.Text = "";
                                foreach (ZipArchiveEntry entry in archive.Entries)
                                {
                                    x++;
                                    prgContador.Value = x;
                                    entry.ExtractToFile(Path.Combine(Diretorio, entry.FullName), true);
                                    listBox1.Items.Add(entry.Name);
                                    lblStatus.Text = "Arquivos Descompactados:" + x;
                                    lblTotalExtracted.Text = x.ToString();
                                }

                                /*    DirectoryInfo dinfo = new DirectoryInfo(Diretorio);
                                      FileInfo[] Files = dinfo.GetFiles("*");
                                      listBox1.Items.Clear();
                                      foreach (FileInfo file in Files)
                                      {
                                          listBox1.Items.Add(file.Name);
                                      }
                                 */
                            }

                            MessageBox.Show("Arquivos extraidos com sucesso !");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Err:" + ex);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Arquivo não encontrado");
                    }

                }
                else
                {
                    MessageBox.Show("Diretorio não existente, preencha todos os campos para continuar");
                   // throw new DirectoryNotFoundException("O arquivo destino não foi localizado");
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Preencha todos os campos para continuar !");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var task = Task.Run((Func<Task>)Form1.listar);
            task.Wait();
           
        }


        static async Task listar()
        {
            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            

            using (var dbx = new DropboxClient(token))
            {
                var list = await dbx.Files.ListFolderAsync("/dlls");

                foreach (var item in list.Entries.Where(i => i.IsFolder))
                {
                    Console.WriteLine("D  {0}/", item.Name);

                }

                foreach (var item in list.Entries.Where(i => i.IsFile))
                {
                    Console.WriteLine("F{0,8} {1}", item.AsFile.Size, item.Name);
                }
            }
               
        }

    
        private void selectNewDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog caminhoDir = new FolderBrowserDialog();
            caminhoDir.ShowDialog();
            txtValueDirectory.Text = caminhoDir.SelectedPath;
            diretorioPadrao = caminhoDir.SelectedPath;
        }

        private void SelectNewFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ZIP Folders (.ZIP)|*.zip";
            openFileDialog1.ShowDialog();
           // openFileDialog1.DefaultExt = ".pdf|.zip";
           // txtNewFileUpload.Text = openFileDialog1.FileName;
            arquivoParaUpload = openFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ZIP Folders (.ZIP)|*.zip";
            openFileDialog1.ShowDialog();
            txtFileExtracted.Text = openFileDialog1.FileName;
           
        }

        private void btnSelectFolderExtractAll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caminhoDir = new FolderBrowserDialog();
            caminhoDir.ShowDialog();
            txtDirectoryExtratorsFiles.Text = caminhoDir.SelectedPath;
            diretorioExtrair = caminhoDir.SelectedPath;
   
        }

        /*
       private void btn_upload_Click(object sender, EventArgs e)
       {
           // ProgressBar p = new ProgressBar();
           //  p.Location = new Point(50, 20);
           //  p.Size = new Size(100, 30);
           progressBar2.MarqueeAnimationSpeed = 30;
           progressBar2.Style = ProgressBarStyle.Marquee;
           groupBox1.Controls.Add(progressBar2);


           try
           {
               var task = Task.Run((Func<Task>)Form1.UploadArquivos);
               task.Wait();
               if (txtNewFileUpload.Text.ToString().Length != 0)
               {

                     if (task.IsCompleted)
                       {
                           progressBar2.Dispose();
                           lblStatus.Text = "Arquivo Salvo dropbox!";
                           MessageBox.Show("Arquivo Salvo dropbox!");
                       }
                       else
                       {
                           progressBar2.Dispose();
                           lblStatus.Text = "Arquivo Não salvo dropbox!";
                           MessageBox.Show("Arquivo Não salvo dropbox");

                       }

               }
               else
               {
                   MessageBox.Show("Arquivo Não Selecionado");
               }
                // Console.WriteLine(task.IsCompleted);



           }
           catch (Exception ex)
           {
               progressBar2.Dispose();
               MessageBox.Show("erro1:" + ex);

           }


       }


       static async Task UploadArquivos()
       {

           using (var dbx = new DropboxClient(token))
           {
               // ZipFile.CreateFromDirectory(@"C:\img4", @"C:\\img3\img3.zip");
               string file = arquivoParaUpload;
               string folder = "/Aplicativos/dlls";
               string filename = "dlls.zip";
               string url = "";

                       using (var mem = new MemoryStream(File.ReadAllBytes(file)))
                       {
                           try
                           {
                                   var updated =  dbx.Files.UploadAsync(folder + "/" + filename, WriteMode.Overwrite.Instance, body: mem);
                                  // updated.Wait();
                                   var tx = dbx.Sharing.CreateSharedLinkWithSettingsAsync(folder + "/" + filename);
                                   tx.Wait();
                                   url = tx.Result.Url;
                                  // MessageBox.Show("erro1:" + url);


                           }
                           catch(DropboxException ex)
                           {
                                   MessageBox.Show("erro2:" +ex);

                           }

                       }
                       Console.Write(url);

           }
       }

       */
    }
}
