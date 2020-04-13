// Anthony Sturdy - Parallel Data Processing F# Implementation
open System
open System.IO
open System.Linq
open System.Diagnostics
open System.Threading.Tasks
open System.Collections.Concurrent

let mutable fileDir = ""
let mutable storeFilter = ""
let mutable dateFilter = ""
let mutable supplierFilter = ""
let mutable supplierTypeFilter = ""

type Order(_storeCode : string, _date : string, _suppName : string, _suppType : string, _cost : double) =
    member x.storeCode = _storeCode
    member x.date = _date
    member x.suppName = _suppName
    member x.suppType = _suppType
    member x.cost = _cost

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
    Console.WriteLine("\nTo filter the order data, please choose from the following options:")
    Console.WriteLine("1. Store")
    Console.WriteLine("2. Date")
    Console.WriteLine("3. Supplier")
    Console.WriteLine("4. Supplier Type")
    Console.WriteLine("5. Clear Filters")
    Console.WriteLine("6. Print Data")

let PrintData() = 
    Console.WriteLine("Querying data..")

    let sw : Stopwatch = new Stopwatch();
    sw.Start()

    let qObject = orders.ToArray()
    let query = 
        qObject
        |> Seq.filter(fun o -> if storeFilter = "" then true else o.storeCode = storeFilter)        //F# doesn't have ternary (?) operator, so this goes:
        |> Seq.filter(fun o -> if dateFilter = "" then true else o.date = dateFilter)               //If filter is empty, return true, else, return whether filter matches order details
        |> Seq.filter(fun o -> if supplierFilter = "" then true else o.suppName = supplierFilter)
        |> Seq.filter(fun o -> if supplierTypeFilter = "" then true else o.suppType = supplierTypeFilter)

    sw.Stop()
    Console.WriteLine("Results queried using PLINQ took " + Convert.ToString(Convert.ToDouble(sw.ElapsedMilliseconds)/1000.0) + " seconds")

    let totalCost =
        query 
        |> Seq.sumBy( fun o -> o.cost )

    if query.Count() = 0 then
        Console.WriteLine("No matches found with specified filters!")
    else if query.Count() > 150000 then
        Console.WriteLine("A lot of results (" + Convert.ToString(query.Count()) + ") are about to be printed, continue? (y/n)")
        let choice = Console.ReadLine()
        if choice <> "n" then
            for o in query do
                Console.WriteLine(o.storeCode + "\t" + o.date + "\t\t" + o.suppName + "\t" + o.suppType + "\t£" + Convert.ToString(o.cost))
            Console.WriteLine("Total Cost: £" + Convert.ToString(totalCost))
    else
        for o in query do
            Console.WriteLine(o.storeCode + "\t" + o.date + "\t\t" + o.suppName + "\t" + o.suppType + "\t£" + Convert.ToString(o.cost))
        Console.WriteLine("Total Cost: £" + Convert.ToString(totalCost))


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