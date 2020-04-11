open System
open System.IO
open System.Diagnostics
open System.Threading.Tasks
open System.Collections.Generic
open System.Collections.Concurrent

let mutable fileDir = ""
let mutable storeFilter = ""
let mutable dateFilter = ""
let mutable supplierFilter = ""
let mutable supplierTypeFilter = ""

type Order(_storeCode : string, _date : string, _suppName : string, _suppType : string, _cost : double) =
    let storeCode = _storeCode
    let date = _date
    let suppName = _suppName
    let suppType = _suppType
    let cost = _cost

let orders = new ConcurrentBag<Order>()

let Initialise() = 
    while fileDir = "" do    // Need file directory before continuing 
        Console.WriteLine("Input directory containing all order data:")
        fileDir <- Console.ReadLine()

    // Loop through all files
    let fileNames = ConcurrentBag<string>(Directory.GetFiles(@"" + fileDir))

    Console.WriteLine("Loading order data..")

    let sw : Stopwatch = new Stopwatch()
    sw.Start()

    let p = Parallel.ForEach(fileNames, (fun path ->
        let fileName = Path.GetFileNameWithoutExtension(path)
        let splitFileName : string[] = fileName.Split('_')
        
        let store : string = splitFileName.[0]
        let date : string = (splitFileName.[1] + "_" + splitFileName.[2])

        // Loop through each line of this file
        let orderData : string[] = File.ReadAllLines(path)
        for orderLine in orderData do
            let splitOrderInfo : string[] = orderLine.Split(',')

            let supplierName : string = splitOrderInfo.[0]
            let supplierType : string = splitOrderInfo.[1]
            let cost : double = Convert.ToDouble(splitOrderInfo.[2])

            let order : Order = new Order(store, date, supplierName, supplierType, cost)
            
            orders.Add(order)
    ))

    sw.Stop()
    
    Console.WriteLine("Finished Loading " + Convert.ToString(orders.Count) + " files in " + Convert.ToString(Convert.ToDouble(sw.ElapsedMilliseconds)/1000.0) + " seconds.")

let PrintOptions() = 
    // Print user options
    Console.WriteLine("\nTo filter the order date, please choose from the following options:")
    Console.WriteLine("1. Store")
    Console.WriteLine("2. Date")
    Console.WriteLine("3. Supplier")
    Console.WriteLine("4. Supplier Type")
    Console.WriteLine("5. Clear Filters")
    Console.WriteLine("6. Print Data")

let PrintData() = 
    Console.WriteLine("Printing data aaaa beep boop")

    // USE LINQ/PLINQ TO FILTER DATA AND DISPLAY

let CheckInput(input : string) =
    if input = "1" then
        Console.WriteLine("Enter Store code you'd like to filter: (e.g. HOV1)")
        storeFilter <- Console.ReadLine()
    else if input = "2" then
        Console.WriteLine("Enter Date you'd like to filter: (e.g. 13_2014 would be Week 13, 2014)")
        dateFilter <- Console.ReadLine()
    else if input = "3" then
        Console.WriteLine("Enter Supplier you'd like to filter: (e.g. Lurpak)")
        supplierFilter <- Console.ReadLine()
    else if input = "4" then
        Console.WriteLine("Enter Supplier Type you'd like to filter: (e.g. Dairy)")
        supplierTypeFilter <- Console.ReadLine()
    else if input = "5" then
        Console.WriteLine("Clearing filters")
        storeFilter <- ""
        dateFilter <- ""
        supplierFilter <- ""
        supplierTypeFilter <- ""
    else if input = "6" then
        PrintData()

    PrintOptions()

let MainLoop() =
    Initialise()
    PrintOptions()

    let mutable quit = false
    while quit <> true do
        let input = Console.ReadLine()

        match input with
        | "quit" -> quit <- true
        | _ -> CheckInput(input)

MainLoop()