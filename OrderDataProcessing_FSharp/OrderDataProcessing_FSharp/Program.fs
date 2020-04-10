open System
open System.IO
open System.Threading.Tasks

let mutable fileDir = ""

type Order(_storeCode : string, _date : string, _suppName : string, _suppType : string, _cost : double) =
    member this.storeCode = _storeCode
    member this.date = _date
    member this.suppName = _suppName
    member this.suppType = _suppType
    member this.cost = _cost

let Initialise() = 
    while fileDir = "" do    // Need file directory before continuing 
        Console.WriteLine("Input directory containing all order data:")
        fileDir <- Console.ReadLine()

    // Loop through all files
    let fileNames : string[] = Directory.GetFiles(fileDir)
    Parallel.ForEach(fileNames, (fun path -> 
        let fileName = Path.GetFileNameWithoutExtension(path)
        let splitFileName : string[] = fileName.Split('_')
        // TODO: CONTINUE CONVERTING C# LOADING CODE TO F#
    ))

    // Print user options
    Console.WriteLine("\nTo filter the order date, please choose from the following options:")
    Console.WriteLine("1. Store")
    Console.WriteLine("2. Supplier")
    Console.WriteLine("3. Supplier Type")
    Console.WriteLine("4. Date")
    Console.WriteLine("5. Clear Filters")
    Console.WriteLine("6. Print Data")
        

let CheckInput(input : string) =
    Console.WriteLine(input)

let MainLoop() =
    Initialise()

    let mutable quit = false
    while quit <> true do
        let input = Console.ReadLine()

        match input with
        | "quit" -> quit <- true
        | _ -> CheckInput(input)

MainLoop()