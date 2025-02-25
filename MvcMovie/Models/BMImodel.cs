namespace Net_Core_API;

public class BMImodel
using System.ComponentModel.DataAnnotations;

namespace BMICalculatorApp.Models
{
    public class BMICalculator
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng")]
        [Range(1, 500, ErrorMessage = "Cân nặng phải từ 1 đến 500 kg")]
        public double Weight { get; set; }  // Cân nặng (kg)

        [Required(ErrorMessage = "Vui lòng nhập chiều cao")]
        [Range(0.5, 2.5, ErrorMessage = "Chiều cao phải từ 0.5 đến 2.5 m")]
        public double Height { get; set; }  // Chiều cao (m)

        public double BMI { get; set; } // Chỉ số BMI

        public string Category { get; set; } // Phân loại BMI
    }
}
