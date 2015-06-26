open System

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.


[<EntryPoint>]
let main argv = 
    let shipment = EasyPostHelper.getRates
    if not( shipment.rates = null )then
        Console.WriteLine("Found rates!")
    else
        Console.WriteLine("Rates do not exist")
    0


