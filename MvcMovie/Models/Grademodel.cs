using System.ComponentModel.DataAnnotations;

namespace GradeCalculatorApp.Models
{
    public class GradeCalculator
    {
        [Required(ErrorMessage = "Vui lòng nhập điểm bài kiểm tra")]
        [Range(0, 10, ErrorMessage = "Điểm phải từ 0 đến 10")]
        public double TestScore { get; set; } // Điểm bài kiểm tra

        [Required(ErrorMessage = "Vui lòng nhập điểm giữa kỳ")]
        [Range(0, 10, ErrorMessage = "Điểm phải từ 0 đến 10")]
        public double MidtermScore { get; set; } // Điểm giữa kỳ

        [Required(ErrorMessage = "Vui lòng nhập điểm cuối kỳ")]
        [Range(0, 10, ErrorMessage = "Điểm phải từ 0 đến 10")]
        public double FinalScore { get; set; } // Điểm cuối kỳ

        public double AverageScore { get; set; } // Điểm trung bình
        public string Grade { get; set; } // Xếp loại

        // Tính điểm trung bình và xếp loại
        public void CalculateGrade()
        {
            AverageScore = (TestScore * 0.3) + (MidtermScore * 0.3) + (FinalScore * 0.4);
            Grade = GetGrade(AverageScore);
        }

        private string GetGrade(double score)
        {
            if (score >= 8.5) return "Giỏi";
            if (score >= 7.0) return "Khá";
            if (score >= 5.0) return "Trung bình";
            return "Yếu";
        }
    }
}

