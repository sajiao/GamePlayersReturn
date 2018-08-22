using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.PartnerService
{
   public class PartnerServiceFactory
    {
        private static readonly Dictionary<string, Object> PartnerServicesDictionary = new Dictionary<string, Object>();

        public static IPartnerService CreatePayService(string name)
        {
            if (string.IsNullOrEmpty(name)) name = string.Empty;
            name = name.Trim().ToUpper();

            IPartnerService service = GetPartnerService(name);

            return service;
        }

        private static IPartnerService GetPartnerService(string name)
        {
            Object service = null;
            if (!PartnerServicesDictionary.TryGetValue(name, out service))
                service = new PartnerServiceFactory().CreatePartnerServices(name);

            return (IPartnerService)service;
        }

        private Object CreatePartnerServices(string name)
        {
            Object service = null;
            try
            {
                Type[] typeList = this.GetType().Assembly.GetExportedTypes();
                if (typeList != null)
                {
                    foreach (Type type in typeList)
                    {
                        var attributes = type.GetCustomAttributes(typeof(PartnerServiceAttribute), true);
                        if (attributes != null && attributes.Count() > 0)
                        {
                            var matchedAttribute = attributes.FirstOrDefault();
                            if (matchedAttribute != null)
                            {
                                string serviceKey = ((PartnerServiceAttribute)matchedAttribute).PartnerServiceName.ToUpper();
                                var currentService = Activator.CreateInstance(type);

                                if (name == serviceKey) service = currentService;

                                if (!PartnerServicesDictionary.ContainsKey(serviceKey))
                                {
                                    PartnerServicesDictionary.Add(serviceKey, currentService);
                                }
                            }

                        }
                    }
                }
            }
            catch
            {
                service = null;
            }
            return service;
        }
    }
}
