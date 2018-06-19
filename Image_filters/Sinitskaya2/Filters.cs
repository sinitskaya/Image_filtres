using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;


namespace Sinitskaya2
{
    abstract class Filters
    {
        public Random rand = new Random();
        protected virtual Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {//вычисляет значение пикселя отфильтрованного изобр
            return Color.Black;
        }
        public Bitmap processImage(Bitmap sourceImage)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);//создание пустого изображение ого же размера
            for (int i = 0; i < sourceImage.Width; ++i)
                for (int j = 0; j < sourceImage.Height; j++)
                    resultImage.SetPixel(i,j, calculateNewPixelColor(sourceImage, i, j));
            //установление пикселю с текущими координатами значение функции calculateNewPixelColor
                    return resultImage;

        }
        public int clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public virtual Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            BeforeProcessImage(sourceImage);
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));//сигнализирует элементу BackgrooundWorker о текущем прогрессе
                if (worker.CancellationPending)//Возвращает значение, указывающее, запросило ли приложение отмену фоновой операции.
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
        protected virtual void BeforeProcessImage(Bitmap sourceImage)
        { }

    }

    class  InvertFilter: Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {//вычисляет значение пикселя отфильтр изобр
            Color sourceColor = sourceImage.GetPixel(x,y);//получение цвета исходного пикселя
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);//вычисление инверсии
            return resultColor;//цвет пикселя
        }
    }
    /// ///////////////////////////////////////////////////
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;//двумерный массив ядро

        protected MatrixFilter() { }
        protected MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)//вычисляет цвет пикселя на основании своих соседей
        {
            //радиусы фильтра по ширине и высоте
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            //хранятся цветовые компоненты результируещего цвета
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)//положение точки в матрице ядра
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);//координаты пикселей-соседей пикселя (x y), для кот происход вычислене цв
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);//цвет соседнего пикселя
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(clamp((int)resultR, 0, 255), clamp((int)resultG, 0, 255), clamp((int)resultB, 0, 255));
        }
    }
    /// ///////////////////////////////////////////////////
    class BlurFilter : MatrixFilter//размытие
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
        }
    }

    /// ///////////////////////////////////////////////////
    class GaussianFilter : MatrixFilter
    {
        public GaussianFilter()
        {
            createGaussianKernel(3, 2);//создает фильтр размером 7*7(2*3+1=7) и с коэф сигма=2
        }

        public void createGaussianKernel(int radius, float sigma)//расчитывает ядро преобразования по формуле гаусса
        {
            //определяем размер ядра
            int size = 2 * radius + 1;
            //создаем ядро фильтра
            kernel = new float[size, size];
            //коэффициент нормировки ядра
            float norm = 0;
            //расчитываем ядро линейного фильтра
            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            //нормируем ядро
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
        }   
    }

    /// ///////////////////////////////////////////
    class GrayScaleFilter : Filters //черно-белое
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int Intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.B + 0.11 * sourceColor.G);
            Color resultColor = Color.FromArgb(clamp(Intensity,0,255), clamp(Intensity, 0, 255), clamp(Intensity, 0, 255));
            return resultColor;
        }
    }
    
    //////////////////////////////////////////
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k = 50;
            Color sourceColor = sourceImage.GetPixel(x, y);
            int Intensity = (int)(0.36 * sourceColor.R + 0.53 * sourceColor.B + 0.11 * sourceColor.G);
            Color resultColor = Color.FromArgb(clamp(Intensity+2*k, 0, 255), clamp((int)(Intensity + 0.5 * k), 0, 255), clamp(Intensity - 1 * k, 0, 255));
            return resultColor;
        }
    }

    class YarkostFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int Const = 50;
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(clamp(Const+sourceColor.R, 0, 255), clamp(Const + sourceColor.G, 0, 255), clamp(Const + sourceColor.B, 0, 255));
            return resultColor;
        }
    }

    /// //////////////////////////////////////////////////
    class Sobel : MatrixFilter
    {
        public int[,] sobelX = new int[3, 3] {  {-1, 0, 1},
                                                {-2, 0, 2},
                                                {-1, 0, 1} };

        public int[,] sobelY = new int[3, 3] {  {-1, -2, -1},
                                                {0, 0, 0},
                                                {1, 2, 1} };

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = 1;
            int radiusY = 1;
            float XresultR = 0;
            float XresultG = 0;
            float XresultB = 0;
            float YresultR = 0;
            float YresultG = 0;
            float YresultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    XresultR += neighborColor.R * sobelX[k + radiusX, l + radiusY];
                    XresultG += neighborColor.G * sobelX[k + radiusX, l + radiusY];
                    XresultB += neighborColor.B * sobelX[k + radiusX, l + radiusY];
                    YresultR += neighborColor.R * sobelY[k + radiusX, l + radiusY];
                    YresultG += neighborColor.G * sobelY[k + radiusX, l + radiusY];
                    YresultB += neighborColor.B * sobelY[k + radiusX, l + radiusY];
                }
            Color cX = Color.FromArgb( clamp((int)XresultR, 0, 255), clamp((int)XresultG, 0, 255), clamp((int)XresultB, 0, 255) );//производная по x
            Color cY = Color.FromArgb( clamp((int)YresultR, 0, 255), clamp((int)YresultG, 0, 255), clamp((int)YresultB, 0, 255) );
            Color res = SumColor(cX, cY);//градиент
            return res;
        }

        private Color SumColor(Color a, Color b)//градиент
        {
            Color rescolor = Color.FromArgb(
                clamp((int)Math.Sqrt(Math.Pow(a.R, 2) + Math.Pow(b.R, 2)), 0, 255),
                clamp((int)Math.Sqrt(Math.Pow(a.G, 2) + Math.Pow(b.G, 2)), 0, 255),
                clamp((int)Math.Sqrt(Math.Pow(a.B, 2) + Math.Pow(b.B, 2)), 0, 255) );
            return rescolor;
        }

        
    }
    ///////////////////////////////////////////////////

    class Rezkost : MatrixFilter
    {
        public Rezkost()
        {
            kernel = new float[3, 3];

            kernel[0, 0] = 0;
            kernel[0, 1] = -1;
            kernel[0, 2] = 0;
            kernel[1, 0] = -1;
            kernel[1, 1] = 5;
            kernel[1, 2] = -1;
            kernel[2, 0] = 0;
            kernel[2, 1] = -1;
            kernel[2, 2] = 0;
        }
    }

    /*class Tisnenie : MatrixFilter
    {
        public Tisnenie()
        {
            kernel = new float[3, 3];

            kernel[0, 0] = 0;
            kernel[0, 1] = 1;
            kernel[0, 2] = 0;
            kernel[1, 0] = 1;
            kernel[1, 1] = 0;
            kernel[1, 2] = -1;
            kernel[2, 0] = 0;
            kernel[2, 1] = -1;
            kernel[2, 2] = 0;
        }
    }*/

    class MotionBlur : MatrixFilter
    {
        public MotionBlur(int n)
        {
            int sizeX = n;
            int sizeY = n;
            kernel = new float[sizeX, sizeY];
            for(int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                {
                    if(i!=j)
                        kernel[i,j]=0;
                    else
                        kernel[i, j] = (float)(1.0/n);
                }
        }
    }
    class Glass : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = sourceColor;
            if (x > 5 && x < sourceImage.Width - 5 && y > 5 && y < sourceImage.Height - 5)
            {
                int temp_x = (int)(x + (rand.NextDouble() - 0.5) * 10);//0до1
                int temp_y = (int)(y + (rand.NextDouble() - 0.5) * 10);
                resultColor = sourceImage.GetPixel(temp_x, temp_y);
            }
            return resultColor;
        }
    }
    class Transfer : Filters//перенос
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int delta = 50;//перенос влево
            Color resultColor;
            if (x < sourceImage.Width - delta)
            {
                resultColor = sourceImage.GetPixel(x + delta, y);
            }
            else
            {
                Color sourceColor = sourceImage.GetPixel(x, y);
                resultColor = Color.Black;////////0 0 0
            }
            return resultColor;
        }
    }
    class Median : MatrixFilter
    {
        public Median(int n)
        {
            kernel = new float[n, n];
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            int n = kernel.GetLength(0) * kernel.GetLength(1);
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            int[] cR = new int[n];
            int[] cB = new int[n];
            int[] cG = new int[n];
            int g = 0;

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, radiusX, sourceImage.Width - radiusX);
                    int idY = clamp(y + l, radiusY, sourceImage.Height - radiusY);
                    Color c = sourceImage.GetPixel(idX, idY);
                    cR[g] = c.R;
                    cG[g] = c.G;
                    cB[g] = c.B;
                    g++;
                }

            quickSort(cR, 0, n - 1);
            quickSort(cG, 0, n - 1);
            quickSort(cB, 0, n - 1);
            int med = (int)(n / 2);// с 0
            resultR = cR[med];
            resultG = cG[med];
            resultB = cB[med];
            return Color.FromArgb( clamp((int)resultR, 0, 255), clamp((int)resultG, 0, 255), clamp((int)resultB, 0, 255) );
        }

        static void quickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];

            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }
    }

    class GrayWorld : Filters
    {
        private float Avg;
        private float avgR;
        private float avgG;
        private float avgB;

        private void FindAvg(Bitmap sourceImage)
        {
            int n = sourceImage.Width * sourceImage.Height;
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    sumR += sourceImage.GetPixel(i, j).R;
                    sumG += sourceImage.GetPixel(i, j).G;
                    sumB += sourceImage.GetPixel(i, j).B;
                }
            }
            avgR = sumR / n;
            avgG = sumG / n;
            avgB = sumB / n;
            Avg = (avgR + avgB + avgG) / 3;//средние яркости по всем каналам
        }

        protected override void BeforeProcessImage(Bitmap sourceImage)
        {
            FindAvg(sourceImage);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {//Масштабировать яркости пикселей по следующим коэффициентам
            int R = clamp((int)(sourceImage.GetPixel(x, y).R * Avg / avgR), 0, 255);
            int G = clamp((int)(sourceImage.GetPixel(x, y).G * Avg / avgG), 0, 255);
            int B = clamp((int)(sourceImage.GetPixel(x, y).B * Avg / avgB), 0, 255);
            Color c = Color.FromArgb(R, G, B);
            return c;
        }
    }

    class LinearStretching : Filters
    {
        int maxR, minR, maxG, minG, maxB, minB;

        private void FindMaxMin(Bitmap sourceImage)
        {
            maxR = sourceImage.GetPixel(0, 0).R;
            minR = sourceImage.GetPixel(0, 0).R;
            maxG = sourceImage.GetPixel(0, 0).G;
            minG = sourceImage.GetPixel(0, 0).G;
            maxB = sourceImage.GetPixel(0, 0).B;
            minB = sourceImage.GetPixel(0, 0).B;


            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color c = sourceImage.GetPixel(i, j);

                    if (minR > c.R) minR = c.R;
                    if (maxR < c.R) maxR = c.R;
                    if (minG > c.G) minG = c.G;
                    if (maxG < c.G) maxG = c.G;
                    if (minB > c.B) minB = c.B;
                    if (maxB < c.B) maxB = c.B;

                }
            }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int R = (sourceImage.GetPixel(x, y).R - minR) * (255 / (maxR - minR));
            int G = (sourceImage.GetPixel(x, y).G - minG) * (255 / (maxG - minG));
            int B = (sourceImage.GetPixel(x, y).B - minB) * (255 / (maxB - minB));
            Color c = Color.FromArgb(R, G, B);
            return c;
        }

        protected override void BeforeProcessImage(Bitmap sourceImage)
        {
            FindMaxMin(sourceImage);
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////
    /// </summary>
    public enum MaskType//объявления перечисления — отдельного типа, который состоит из набора именованных констант, называемого списком перечислителей
    {
        Square3, Square5, Cross3
    }
    abstract class MatMorphology : Filters
    {
        public bool[,] structElem;

        public MatMorphology(MaskType maskType)
        {
            switch (maskType)
            {
                case MaskType.Square3:
                    {
                        structElem = new bool[,]{
                                                {true, true, true},
                                                {true, true, true},
                                                {true, true, true}};
                        break;
                    }
                case MaskType.Cross3:
                    {
                        structElem = new bool[,]{
                                                 {false, true, false},
                                                 {true, true, true},
                                                 {false, true, false}};
                        break;
                    }
                case MaskType.Square5:
                    {
                        structElem = new bool[,]{
                                                {true, true, true, true, true},
                                                {true, true, true, true, true},
                                                {true, true, true, true, true},
                                                {true, true, true, true, true},
                                                {true, true, true, true, true}};
                        break;
                    }
            }
        }

        public Bitmap Dilation(Bitmap sourceImage, BackgroundWorker worker)//расширение
        {//выбор пикселя с мак интенсивностью из окрестности. 
         //увеличение светлых обьектов
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap res = new Bitmap(sourceImage);
            int structWidth = structElem.GetLength(0);//размеры структурного множества
            int structHeight = structElem.GetLength(1);

            for (int y = structHeight / 2; y < height - structHeight / 2; y++)
            {
                worker.ReportProgress((int)((float)y / sourceImage.Width * 100));
                for (int x = structWidth / 2; x < width - structWidth / 2; x++)
                {
                    int maxR = sourceImage.GetPixel(x, y).R; ;
                    int maxG = sourceImage.GetPixel(x, y).G; ;
                    int maxB = sourceImage.GetPixel(x, y).B; ;
                    int k = 0;
                    for (int j = -structHeight / 2; j <= structHeight / 2; j++)
                    {
                        int l = 0;
                        for (int i = -structWidth / 2; i <= structWidth / 2; i++)
                        {
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).R > maxR))
                                maxR = sourceImage.GetPixel(x + i, y + j).R;
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).G > maxG))
                                maxG = sourceImage.GetPixel(x + i, y + j).G;
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).B > maxB))
                                maxB = sourceImage.GetPixel(x + i, y + j).B;
                            l++;
                        }
                        k++;
                    }
                    Color col = Color.FromArgb(maxR, maxG, maxB);
                    res.SetPixel(x, y, col);
                }
            }
            return res;
        }

        public Bitmap Erosion(Bitmap sourceImage, BackgroundWorker worker)//сужение
        {//выбор пикселя с мин интенсивностью из окрестности. 
         //увеличение темных обьектов
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap res = new Bitmap(sourceImage);
            int structWidth = structElem.GetLength(0);
            int structHeight = structElem.GetLength(1);

            for (int y = structHeight / 2; y < height - structHeight / 2; y++)
            {
                worker.ReportProgress((int)((float)y / sourceImage.Width * 100));
                for (int x = structWidth / 2; x < width - structWidth / 2; x++)
                {

                    int minR = sourceImage.GetPixel(x, y).R;
                    int minG = sourceImage.GetPixel(x, y).G;
                    int minB = sourceImage.GetPixel(x, y).B;

                    int k = 0;
                    for (int j = -structHeight / 2; j <= structHeight / 2; j++)
                    {
                        int l = 0;
                        for (int i = -structWidth / 2; i <= structWidth / 2; i++)
                        {
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).R < minR))
                                minR = sourceImage.GetPixel(x + i, y + j).R;
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).G < minG))
                                minG = sourceImage.GetPixel(x + i, y + j).G;
                            if ((structElem[l, k]) && (sourceImage.GetPixel(x + i, y + j).B < minB))
                                minB = sourceImage.GetPixel(x + i, y + j).B;
                            l++;
                        }
                        k++;
                    }
                    Color col = Color.FromArgb(minR, minG, minB);
                    res.SetPixel(x, y, col);
                }
            }
            return res;
        }

        public Bitmap Opening(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap res = new Bitmap(sourceImage);
            res = Erosion(sourceImage, worker);
            res = Dilation(sourceImage, worker);
            return res;
        }

        public Bitmap Closing(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap res = new Bitmap(sourceImage);
            res = Dilation(sourceImage, worker);
            res = Erosion(res, worker);
            return res;
        }
    }
    ///////////////////////////////////////////////////////////
    class ErosionF : MatMorphology//выбор пикселя с мин интенсивностью из окрестности. 
        //увеличение темных обьектов
    {
        public ErosionF(MaskType maskType) : base(maskType){ }//для вызова конструктора базового класса

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            resultImage = Erosion(sourceImage, worker);
            return resultImage;
        }
    }
    class DilationF : MatMorphology
    {
        public DilationF(MaskType maskType): base(maskType){}

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            resultImage = Dilation(sourceImage, worker);
            return resultImage;
        }
    }

    class Closing : MatMorphology
    {
        public Closing(MaskType maskType): base(maskType){}

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = Closing(sourceImage, worker);
            return resultImage;
        }
    }
    class Opening : MatMorphology
    {
        public Opening(MaskType maskType): base(maskType){}

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            resultImage = Opening(sourceImage, worker);
            return resultImage;
        }
    }
    class Grad : MatMorphology
    {
        public Grad(MaskType maskType): base(maskType){}
        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap tempImage_1 = new Bitmap(sourceImage.Width, sourceImage.Height);
            Bitmap tempImage_2 = new Bitmap(sourceImage.Width, sourceImage.Height);
            tempImage_1 = Dilation(sourceImage, worker);
            worker.ReportProgress((int)(33));
            tempImage_2 = Erosion(sourceImage, worker);
            worker.ReportProgress((int)(66));
            Color col;
            int R, G, B;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress(66 + (int)(33 * i / resultImage.Width));
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    R = tempImage_1.GetPixel(i, j).R - tempImage_2.GetPixel(i, j).R;
                    G = tempImage_1.GetPixel(i, j).G - tempImage_2.GetPixel(i, j).G;
                    B = tempImage_1.GetPixel(i, j).B - tempImage_2.GetPixel(i, j).B;
                    R = clamp(R, 0, 255);
                    G = clamp(G, 0, 255);
                    B = clamp(B, 0, 255);
                    col = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(i, j, col);
                }
            }
            return resultImage;
        }
    }
}