//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerMover {
    using Gadgeteer;
    using GTM = Gadgeteer.Modules;
    
    
    public partial class Program : Gadgeteer.Program {
        
        /// <summary>The Gyro module using socket 2 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Gyro gyro;
        
        /// <summary>The Motor Driver L298 module using socket 1 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.MotorDriverL298 motorDriverL298;
        
        /// <summary>The Button module using socket 3 of the mainboard.</summary>
        private Gadgeteer.Modules.GHIElectronics.Button button;
        
        /// <summary>This property provides access to the Mainboard API. This is normally not necessary for an end user program.</summary>
        protected new static GHIElectronics.Gadgeteer.FEZCerbuinoBee Mainboard {
            get {
                return ((GHIElectronics.Gadgeteer.FEZCerbuinoBee)(Gadgeteer.Program.Mainboard));
            }
            set {
                Gadgeteer.Program.Mainboard = value;
            }
        }
        
        /// <summary>This method runs automatically when the device is powered, and calls ProgramStarted.</summary>
        public static void Main() {
            // Important to initialize the Mainboard first
            Program.Mainboard = new GHIElectronics.Gadgeteer.FEZCerbuinoBee();
            Program p = new Program();
            p.InitializeModules();
            p.ProgramStarted();
            // Starts Dispatcher
            p.Run();
        }
        
        private void InitializeModules() {
            this.gyro = new GTM.GHIElectronics.Gyro(2);
            this.motorDriverL298 = new GTM.GHIElectronics.MotorDriverL298(1);
            this.button = new GTM.GHIElectronics.Button(3);
        }
    }
}