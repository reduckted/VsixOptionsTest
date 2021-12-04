using Microsoft.VisualStudio.Shell.Interop;
using System.ComponentModel;

namespace VsixOptionsTest {

    public class OptionsPage : DialogPage {

        [Category("Testing")]
        [DisplayName("Enable something")]
        [Description("A setting that enables something.")]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }


        public override void SaveSettingsToStorage() {
            base.SaveSettingsToStorage();
        }

        protected override void SaveSetting(PropertyDescriptor property) {
            base.SaveSetting(property);
        }

        public override void SaveSettingsToXml(IVsSettingsWriter writer) {
            base.SaveSettingsToXml(writer);
        }

        protected override void LoadSettingFromStorage(PropertyDescriptor prop) {
            base.LoadSettingFromStorage(prop);
        }

        public override void LoadSettingsFromStorage() {
            base.LoadSettingsFromStorage();
        }

        public override void LoadSettingsFromXml(IVsSettingsReader reader) {
            base.LoadSettingsFromXml(reader);
        }

    }

}
