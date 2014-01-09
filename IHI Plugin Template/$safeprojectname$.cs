using IHI.Server;

namespace IHI.Server.Plugins.$safeprojectname$
{
    public class $safeprojectname$ : Plugin
    {
        public override string Name
        {
            get
            {
                return "$projectname$";
            }
        }
        
        internal EventFirer EventFirer
        {
            get;
            private set;
        }

        /// <summary>
        ///   Called when the plugin is started.
        /// </summary>
        public override void Start(EventFirer eventFirer)
        {
            EventFirer = eventFirer;

            // Here would be a good place to start...
        }
    }
}