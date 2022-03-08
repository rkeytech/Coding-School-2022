using Session_05;

var actionRequest = new ActionRequest()
{
    Input = "Timos",
    Action = ActionEnum.Convert
};

var actionResolver = new ActionResolver();

ActionResponse actionResponse = actionResolver.Execute(actionRequest);

Console.WriteLine(actionResponse.Output);
actionResolver.Logger.ReadAll();