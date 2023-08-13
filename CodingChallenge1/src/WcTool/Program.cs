using CC.WcTool;

var commandArg = args[0];
var filePathArg = args[1];

int output = commandArg switch 
{
    "-c" => FileOperations.GetByteCount(filePathArg),
    "-l" => FileOperations.GetLineCount(filePathArg),
    "-w" => FileOperations.GetWordCount(filePathArg),
    _ => 0
};

if (output == 0)
    Console.WriteLine("Unrecognized switch or the file was empty.");
else
    Console.WriteLine(output);