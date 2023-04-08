using OOP2Example;

ILoggerService databaseLoggerInterface = new DataBaseLoggerService();
DataBaseLoggerService databaseLogger = new DataBaseLoggerService();
ILoggerService fileLogger = new FileLoggerService();
// ExcelLogger excelLogger = new ExcelLogger(); // bu da (excelLogger) eklenirse aşağıda listeye(, new ExcelLogger() yerine) çalışır

LoggerManager loggerManager = new LoggerManager();

loggerManager.Logger(new DataBaseLoggerService()); // 3'üde aynı şeydir(10-11-12 satır)
loggerManager.Logger(databaseLogger);
loggerManager.Logger(databaseLoggerInterface);

loggerManager.Logger(fileLogger);

Console.WriteLine();

List<ILoggerService> loggerManagers = new List<ILoggerService>() { databaseLoggerInterface, databaseLogger,fileLogger, new ExcelLoggerService() };

LoggerManager loggerManager1 = new LoggerManager();
loggerManager1.LoggerList(loggerManagers);
