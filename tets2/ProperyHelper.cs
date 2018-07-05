using System;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace tets2
{
    public static class PropertyHelper
    {
        public static T GetPropertyValue<T>(string propertyName)
        {
            T result = default(T);
            try
            {
                if (Application.Current.Properties.ContainsKey(propertyName))
                {
                    var toDesString = Application.Current.Properties[propertyName].ToString();
                    result = JsonConvert.DeserializeObject<T>(toDesString);
                }
            }
            catch(JsonException)
            {
                //ignore
            }
            return result;
        }

        public static T SetPropertyValue<T>(string propertyName, T value)
        {
            T result = default(T);
            string toInsert = JsonConvert.SerializeObject(value);

            if(Application.Current.Properties.ContainsKey(propertyName))
            {
                Application.Current.Properties[propertyName] = toInsert;
            }
            else
            {
                Application.Current.Properties.Add(propertyName, toInsert);
            }

            return result;
        }
    }

    public static class PropertyEnum
    {

        public static string IdProperty => nameof(IdProperty);
        public static string WId => nameof(WId);
        public static string DId => nameof(DId);
    }
}

