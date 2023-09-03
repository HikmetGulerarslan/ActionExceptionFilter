using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionExceptionFilter.Filters
{
    public class GlobalException : ExceptionFilterAttribute
    {
        public async override Task OnExceptionAsync(ExceptionContext context)
        {
            // ActionResult Exception Fırlatmış mı kontrol ediyoruz.
            if (context.Exception.Message != null)
            {
                //ActionResult'tan Exception dönüyorsa gelen hata mesajını yakalıyoruz.
                string message = context.Exception.Message;

                // Belirtmiş olduğumuz Custom Hata sayfasına yönlendiriyoruz.
                context.Result = new RedirectResult("/ErrorPage"); 
            }
        }
    }
}
