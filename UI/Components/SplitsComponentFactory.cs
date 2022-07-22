using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class SplitsComponentFactory : IComponentFactory
    {
        public string ComponentName => "Splits w/ Counter";

        public string Description => "Splits with a Counter. Made by Minibeast.";

        public ComponentCategory Category => ComponentCategory.List;

        public IComponent Create(LiveSplitState state) => new SplitsComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "https://minibeast.github.io/files/LiveSplit.CounterSplits/update.LiveSplit.CounterSplits.xml";

        public string UpdateURL => "https://minibeast.github.io/files/";

        public Version Version => Version.Parse("1.0.0");
    }
}
