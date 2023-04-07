using OOP2Example;

ILoggerService databaseLogger = new DataBaseLoggerService();
ILoggerService fileLogger = new FileLoggerService();
// ExcelLogger excelLogger = new ExcelLogger(); // bu da (excelLogger) eklenirse aşağıda listeye(, new ExcelLogger() yerine) çalışır

LoggerManager loggerManager = new LoggerManager();
loggerManager.Logger(fileLogger);
loggerManager.Logger(databaseLogger);

Console.WriteLine();

List<ILoggerService> loggerManagers = new List<ILoggerService>() { databaseLogger,fileLogger, new ExcelLoggerService() };

LoggerManager loggerManager1 = new LoggerManager();
loggerManager1.LoggerList(loggerManagers);
