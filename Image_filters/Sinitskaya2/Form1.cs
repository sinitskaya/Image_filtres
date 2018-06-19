using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinitskaya2
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();//Загружает откомпилированную страницу компонента
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//Отображает диалоговое окно, позволяющее пользователю открыть файл
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)//if the OK button was clicked on the dialog box
            {
                image = new Bitmap(dialog.FileName);//dialog.FileName- выбранное изображение
                pictureBox1.Image = image; //визуализ на форме
                pictureBox1.Refresh();//обновление  puctureBox
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
            //DoWork возникает при вызове RunWorkerAsync метода. Это связано с начала операции, выполняемой потенциально долгой работы.
            /*Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)//Возвращает значение, указывающее, запросило ли приложение отмену фоновой операции.
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;//изменяет цвет полосы
            //Возвращает процент выполнения асинхронной задачи.
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {//визуализац обработанного изобр на форме и обнуление полосы прогресса
            if (!e.Cancelled)//Возвращает значение, указывающее, была ли отменена асинхронная операция.
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;//обнуление полосы прогресса
        }

        private void button1_Click(object sender, EventArgs e)// кнопка омены
        {
            backgroundWorker1.CancelAsync();//остановить выполнение фильтра
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SepiaFilter filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void яркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YarkostFilter filter = new YarkostFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void чернобелоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayScaleFilter filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Rezkost();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        /*private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Filters filter = new Rezkost();
             backgroundWorker1.RunWorkerAsync(filter);
         }*/

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlur(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void гаусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void собеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Sobel();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void перерносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Transfer();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void стеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Glass();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new Median(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretching();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void крест3х3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Filters filter = new ErosionF(MaskType.Cross3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат3х3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ErosionF(MaskType.Square3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат5х5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ErosionF(MaskType.Square5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void крест3х3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing(MaskType.Cross3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат3х3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing(MaskType.Square3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат5х5ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Filters filter = new Closing(MaskType.Square5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void крест3х3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening(MaskType.Cross3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат3х3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening(MaskType.Square3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат5х5ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new Opening(MaskType.Square5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void крест3х3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new DilationF(MaskType.Cross3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат3х3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new DilationF(MaskType.Square3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат5х5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new DilationF(MaskType.Square5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void крест3х3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Filters filter = new Grad(MaskType.Cross3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат3х3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Filters filter = new Grad(MaskType.Square3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void квадрат5х5ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Filters filter = new Grad(MaskType.Square5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        
    }
}





