namespace Ballons.Properties {


    // Ta klasa służy do obsługi określonych zdarzeń klasy ustawień:
    //  SettingChanging zdarzenie występuje przed zmianą wartości parametru. 
    //  PropertyChanged zdarzenie jest wywoływane po zmianie wartości parametru.
    //  SettingsLoaded zdarzenie występuje po załadowaniu wartości parametrów.
    //  SettingsSaving zdarzenie występuje przed zachowaniem wartości parametrów.
    internal sealed partial class Settings {
        
        public Settings() {
            // // Aby dodać obsługę zdarzeń dla zapisywania i zmiana ustawień, należy odkomentować następującą linię: 
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Dodaj kod do obsługi zdarzeń SettingChangingEvent.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Dodaj kod do obsługi zdarzeń SettingsSaving.
        }
    }
}
