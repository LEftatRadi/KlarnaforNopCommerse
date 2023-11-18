using Nop.Core;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Payments;
using Nop.Services.Plugins;
using System;

namespace Nop.Plugin.Payments.Klarna
{
    public class KlarnaPaymentProcessor : BasePlugin
    {
        #region Ctor
        public KlarnaPaymentProcessor()
        {


        }


        /*ISettingService settingService,
            ILocalizationService localizationService,
            IWebHelper webHelper,
            StripeStandardPaymentSettings stripeStandardPaymentSettings,
            IPaymentService paymentService
            )
        {
            _settingService = settingService;
            _localizationService = localizationService;
            _webHelper = webHelper;
            _stripeStandardPaymentSettings = stripeStandardPaymentSettings;
            _paymentService = paymentService;
        }*/

        #endregion



        #region Fields
        //private readonly CurrencySettings _currencySettings;
        //private readonly IAddressService _addressService;
        //private readonly ICheckoutAttributeParser _checkoutAttributeParser;
        //private readonly ICountryService _countryService;
        //private readonly ICurrencyService _currencyService;
        //private readonly ICustomerService _customerService;
        //private readonly IGenericAttributeService _genericAttributeService;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILocalizationService _localizationService;
        //private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        //private readonly IProductService _productService;
        private readonly ISettingService _settingService;
        //private readonly IStateProvinceService _stateProvinceService;
        //private readonly ITaxService _taxService;
        private readonly IWebHelper _webHelper;

        #endregion



    }
}
