namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Services.Resources

open System
open JetBrains.Application.I18n
open JetBrains.DataFlow
open JetBrains.Diagnostics
open JetBrains.Lifetimes
open JetBrains.Util
open JetBrains.Util.Logging

[<global.System.Diagnostics.DebuggerNonUserCode>]
[<global.System.Runtime.CompilerServices.CompilerGenerated>]
type public Strings() =
    static let logger = Logger.GetLogger("JetBrains.ReSharper.Plugins.FSharp.Psi.Services.Resources.Strings")

    static let mutable resourceManager = null

    static do
        CultureContextComponent.Instance.WhenNotNull(Lifetime.Eternal, fun lifetime instance ->
            lifetime.Bracket(
                (fun () ->
                    resourceManager <-
                        lazy
                            instance.CreateResourceManager("JetBrains.ReSharper.Plugins.FSharp.Psi.Services.Resources.Strings",
                                typeof<Strings>.Assembly)),
                (fun () -> resourceManager <- null)
            )
        )

    [<global.System.ComponentModel.EditorBrowsable(global.System.ComponentModel.EditorBrowsableState.Advanced)>]
    static member ResourceManager: JetResourceManager =
        match resourceManager with
            | null -> ErrorJetResourceManager.Instance
            | _ -> resourceManager.Value

    static member String1 = Strings.ResourceManager.GetString("String1")
    static member Message = Strings.ResourceManager.GetString("Message")
    static member Hello = Strings.ResourceManager.GetString("Hello")
    static member ToModuleText = Strings.ResourceManager.GetString("ToModuleText")