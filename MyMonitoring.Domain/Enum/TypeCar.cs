using System.ComponentModel.DataAnnotations;

namespace MyMonitoring.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Легковой автомобиль")]
        PassengerCar = 0,
        [Display(Name = "Седан")]
        Sedan = 1,
        [Display(Name = "Хэтчбек")]
        HachBack = 2,
        [Display(Name = "Минивэн")]
        Minivan = 3,
        [Display(Name = "Спортивный автомобиль")]
        SportsCar = 4,
        [Display(Name = "Внедорожник")]
        Suv = 5
    }
}