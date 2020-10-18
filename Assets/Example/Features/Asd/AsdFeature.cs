using ME.ECS;

namespace Example.Features {

    using Components; using Modules; using Systems; using Features; using Markers;
    using Asd.Components; using Asd.Modules; using Asd.Systems; using Asd.Markers;
    
    namespace Asd.Components {}
    namespace Asd.Modules {}
    namespace Asd.Systems {}
    namespace Asd.Markers {}
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class AsdFeature : Feature {

        protected override void OnConstruct() {
            
        }

        protected override void OnDeconstruct() {
            
        }

    }

}