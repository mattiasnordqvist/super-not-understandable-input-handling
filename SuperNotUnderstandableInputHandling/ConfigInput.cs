using System.Linq;
using Microsoft.Extensions.Configuration;

namespace SuperNotUnderstandableInputHandling
{
    public class ConfigInput : IInput
    {
        private IConfigurationSection configurationSection;

        public ConfigInput(IConfigurationSection configurationSection)
        {
            this.configurationSection = configurationSection;
        }

        public string Name => "AppSettings";

        public TrySetResult<T> TrySet<T>(Param<T> param)
        {
            if (param.optional && !configurationSection.GetChildren().Any(x => x.Key == param.inputParam.Name))
            {
                return null;
            }
            else
            {
                var value = param.inputParam.Parse(configurationSection[param.inputParam.Name]);
                param.SetValue(value);
                return new TrySetResult<T>(param.inputParam.Name, value, Name);
            }
        }
    }
}
