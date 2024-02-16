using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning;
using Accord.Math;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Models.Regression.Linear;
using Accord.Statistics.Models.Regression.Fitting;
using Accord.Math.Optimization.Losses;
//using Accord.MachineLearning.VectorMachines.SupportVector;
//using Accord.MachineLearning.VectorMachines.SupportVector.Clustering;
//using Accord.MachineLearning.VectorMachines.SupportVector.Regulation;
namespace BLL
{
    public class ThuatToanBLL
    {
        private MultipleLinearRegression regressionModel;

        public void TrainAndPredict(List<ThuatToan> bookDataList)
        {
            TrainModel(bookDataList);
        }

        private void TrainModel(List<ThuatToan> bookDataList)
        {
            double[][] inputs = bookDataList.Select(data => new double[] { (double)data.THUCUONG.MATU, data.SLNhap ?? 0.0, data.SLBan ?? 0.0, ConvertToNumeric(data.ThoiGian) }).ToArray();
            double[] outputs = bookDataList.Select(data => (double)(data.DuDoanDoanhSo ?? 0)).ToArray();

            var nnls = new NonNegativeLeastSquares()
            {
                MaxIterations = 100
            };

            regressionModel = nnls.Learn(inputs, outputs);
        }

        public double PredictSalesForBook(int maSach, int slNhap, int slBan, DateTime thoiGian)
        {
            if (regressionModel == null)
            {
                throw new InvalidOperationException("Mô hình chưa được huấn luyện. Vui lòng cung cấp dữ liệu huấn luyện trước.");
            }

            double numericThoiGian = ConvertToNumeric(thoiGian);
            double[] input = { maSach, slNhap, slBan, numericThoiGian };

            // Chuyển đổi mảng kết quả thành danh sách và lấy giá trị đầu tiên
            double predictedValue = regressionModel.Transform(input);

            return predictedValue;
        }

        private double ConvertToNumeric(DateTime thoiGian)
        {
            DateTime baseDate = new DateTime(2000, 1, 1);
            return (thoiGian - baseDate).TotalDays;
        }
    }
}
