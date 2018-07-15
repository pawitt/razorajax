using RazorAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorAjax.Controllers
{
    public class RazorAjaxController : Controller
    {
        // GET: RazorAjax
        public ActionResult Index()
        {
            //return View();
            try { }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }
            // Info.  
            return this.View();
        }


        # region POST: /RazorAjax/Index  
        /// <summary>  
        /// POST: /RazorAjax/Index  
        /// </summary>  
        /// <param name="model">Model parameter</param>  
        /// <returns>Return - RazorAjax content</returns>  
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RazorAjaxViewModels model)
        {
            try
            {
                // Verification  
                if (ModelState.IsValid)
                {
                    // Info.  
                    return this.Json(new
                    {
                        EnableSuccess = true,
                        SuccessTitle = "Success",
                        SuccessMsg = model.Text
                    });
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }
            // Info  
            return this.Json(new
            {
                EnableError = true,
                ErrorTitle = "Error",
                ErrorMsg = "Something goes wrong, please try again later"
            });
        }
        #endregion


    }
}