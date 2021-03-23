using System;
namespace Core.Utilities.Results
{  //Temel voidler için başlangıç.
    public interface IResult //: sonuç
    {
        bool Success { get; } //başarılı  mı başarısız mı bul.
        string Message { get; } // işlem başarılı gibi
    }
}
