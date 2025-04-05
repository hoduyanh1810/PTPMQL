using System.ComponentModel.DataAnnotations;

namespace BTH.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng.")]
        [Range(1, 500, ErrorMessage = "Cân nặng phải từ 1 đến 500 kg.")]
        public double Weight { get; set; } // Cân nặng (kg)

        [Required(ErrorMessage = "Vui lòng nhập chiều cao.")]
        [Range(0.5, 2.5, ErrorMessage = "Chiều cao phải từ 0.5 đến 2.5 m.")]
        public double Height { get; set; } // Chiều cao (m)

        public double BMI => Weight / (Height * Height); // Tính BMI
    }
}
