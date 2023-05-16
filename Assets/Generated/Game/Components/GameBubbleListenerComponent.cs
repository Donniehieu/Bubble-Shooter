//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BubbleListenerComponent bubbleListener { get { return (BubbleListenerComponent)GetComponent(GameComponentsLookup.BubbleListener); } }
    public bool hasBubbleListener { get { return HasComponent(GameComponentsLookup.BubbleListener); } }

    public void AddBubbleListener(System.Collections.Generic.List<IBubbleListener> newValue) {
        var index = GameComponentsLookup.BubbleListener;
        var component = (BubbleListenerComponent)CreateComponent(index, typeof(BubbleListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBubbleListener(System.Collections.Generic.List<IBubbleListener> newValue) {
        var index = GameComponentsLookup.BubbleListener;
        var component = (BubbleListenerComponent)CreateComponent(index, typeof(BubbleListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBubbleListener() {
        RemoveComponent(GameComponentsLookup.BubbleListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBubbleListener;

    public static Entitas.IMatcher<GameEntity> BubbleListener {
        get {
            if (_matcherBubbleListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BubbleListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBubbleListener = matcher;
            }

            return _matcherBubbleListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddBubbleListener(IBubbleListener value) {
        var listeners = hasBubbleListener
            ? bubbleListener.value
            : new System.Collections.Generic.List<IBubbleListener>();
        listeners.Add(value);
        ReplaceBubbleListener(listeners);
    }

    public void RemoveBubbleListener(IBubbleListener value, bool removeComponentWhenEmpty = true) {
        var listeners = bubbleListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveBubbleListener();
        } else {
            ReplaceBubbleListener(listeners);
        }
    }
}
