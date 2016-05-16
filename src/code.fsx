#r "../node_modules/fable-core/Fable.Core.dll"

open Fable.Core 
open Fable.Import
 
Node.require.Invoke("core-js") |> ignore

let element = Browser.document.getElementById "sample"
element.innerText <- "Hello, world !!"