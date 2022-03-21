USE [OTS]
GO
INSERT [dbo].[Level] ([Id], [Name]) VALUES (1, N'easy')
INSERT [dbo].[Level] ([Id], [Name]) VALUES (2, N'medium')
INSERT [dbo].[Level] ([Id], [Name]) VALUES (3, N'hard')
GO
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName]) VALUES (N'ENW392', N'Writing research paper')
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName]) VALUES (N'PRF192', N'Fundamental programming')
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName]) VALUES (N'PRN211', N'Basic C#.NET')
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName]) VALUES (N'PRO192', N'Object oriented programming')
INSERT [dbo].[Subject] ([SubjectCode], [SubjectName]) VALUES (N'SWT301', N'Software Testing')
GO
INSERT [dbo].[Type] ([Id], [Name]) VALUES (1, N'multiple choice')
INSERT [dbo].[Type] ([Id], [Name]) VALUES (2, N'essay')
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (1, N'Which of the following is a MAJOR task of test planning?

A. Scheduling test analysis and design tasks.
B. Initiating corrective actions.
C. Monitoring progress and test coverage.
D. Measuring and analyzing results.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (2, N'Which is a potential product risk factor?

A. Failure of third party vendor
B. Training issues
C. Problems requirements definition
D. Poor software functionality', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (3, N'Who typically use static analysis tools?

A. Customers and users
B. Developers and designers
C. Business and systems analysts
D. System and acceptance testers', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (4, N'Who would USUALLY perform debugging activities?

A. Developers.
B. Analysts.
C. Testers.
D. Incident Managers.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (5, N'Which of the following would you NOT usually find on a software incident report?

A. The name and / or organisational position of the person raising the problem.
B. Version of the Software Under Test.
C. Suggestions as to how to fix the problem.
D. Actual and expected results.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (6, N'Which of the following defines the expected results of a test?

A. Test case specification.
B. Test design specification.
C. Test procedure specification.
D. Test results.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (7, N'In software testing what is the main purpose of exit criteria?

A. To enhance the security of the system
B. To prevent the endless loops in code.
C. To swerve as an alternative or "Plan-B"
D. To define when to stop testing', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (8, N'Which of the following is a KEY test closure task?

A. Ensuring proper environment setup
B. Writing a test summary report
C. Assessing the need for additional tests
D. Finalizing and archiving testware.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (9, N'What is beta testing?

A. Testing performed by potential customers at the developers location.
B. Testing performed by potential customers at their own locations.
C. Testing performed by product developers at the customer''s location.
D. Testing performed by product developers at their own locations.', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (10, N'Which defects are OFTEN much cheaper to remove?

A. Usability defects found by customers
B. Defects in infrequently used functionality
C. Defects that were detected early
D. Minor defects that were found by users', NULL, 1, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (11, N'Which activity in the fundamental test process creates test suites for efficient test execution?

A. Implementation and execution.
B. Planning and control.
C. Analysis and design.
D. Test closure.', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (12, N'When should configuration management procedures be implemented?


A. During test planning.
B. During test analysis.
C. During test execution.
D. When evaluating exit criteria', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (13, N'Which of the problems below BEST characterize a result of software failure?

A. Damaged reputation
B. Lack of methodology
C. Inadequate training
D. Regulatory compliance', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (14, N'What is the MAIN benefit of designing tests early in the life cycle?

A. It is cheaper than designing tests during the test phases.
B. It helps prevent defects from being introduced into the code.
C. Tests designed early are more effective than tests designed later.
D. It saves time during the testing phases when testers are busy.', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (15, N'Which of the following can be considered as success factors when deploying a new tool in an organization?

A. Providing coaching to users and defining usage guidelines
B. Monitoring tool usage and reducing the need for risk analysis
C. Improving processes and focusing more on component testing
D. Assessing testing completion and minimizing code reviews', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (16, N'What is the purpose of exit criteria?

A. To define when a test level is complete.
B. To determine when a test has completed.
C. To identify when a software system should be retired.
D. To determine whether a test has passed.', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (17, N'Which test design technique relies heavily on prior thorough knowledge of the system?

A. Data driven testing technique
B. Experience-based technique
C. White-box technique
D. Structure-based technique', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (18, N'With which of the following categories is a test comparator tool USUALLY associated?

A. Tool support for performance and monitoring.
B. Tool support for static testing.
C. Tool support for test execution and logging.
D. Tool support for the management of testing and tests.', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (19, N'For which of the following would a static analysis tool be MOST useful?

A. Supporting reviews.
B. Validating models of the software.
C. Testing code executed in a special test harness.
D. Enforcement of coding standards.', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (20, N'What principle is BEST described when test designs are written by a third party?

A. Exploratory testing
B. Independent testing
C. Integration testing
D. Interoperability testing', NULL, 2, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (21, N'Which of the following is a benefit of test independence?

A. It does not require familiarity with the code.
B. It is cheaper than using developers to test their own code.
C. It avoids author bias in defining effective tests.
D. Testers are better at finding defects than developers.', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (22, N'Which of the following is a KEY test control task?

A. Initiating corrective actions
B. Determining the scope
C. Implementing the test policy
D. Scheduling test implementation', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (23, N'What is the name of a skeletal implementation of a software component that is used for testing?

A. Use case
B. Domain
C. Driver
D. Stub', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (24, N'Which is the best definition of complete testing:

A. You have discovered every bug in the program.

B. You have tested every statement, branch, and combination of branches in the program.

C. You have completed every test in the test plan.

D. You have reached the scheduled ship date.', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (25, N'Complete statement and branch coverage means:

A. That you have tested every statement in the program.

B. That you have tested every statement and every branch in the program.

C. That you have tested every IF statement in the program.

D. That you have tested every combination of values of IF statements in the program', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (26, N'Typical defects that are easier to find in reviews than in dynamic testing are:

A. Deviations from standards,
B. Requirement defects,
C. Design defects,
D. Insufficient maintainability and incorrect interface specifications.
E. All of the above.', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (27, N'Reviews, static analysis and dynamic testing have the same objective

A. Identifying defects.
B. Fixing defects.
C. A. and B
D. None of the above', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (28, N'What techniques would be MOST appropriate if the specifications are outdated?

A. Structure-based and experienced-based techniques
B. Black-box and specification-based techniques
C. Specification-based and structure-based techniques
D. Structure-based technique and exhaustive testing', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (29, N'Poor software characteristics are

A. Only Project risks
B. Only Product risks
C. Project risks and Product risks
D. Project risks or Product risks', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (30, N'Contract and regulation testing is a part of

A. System testing
B. Acceptance testing
C. Integration testing
D. Smoke testing', NULL, 3, N'SWT301', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (31, N'In order for objects in a List to be sorted, those objects must implement which interface method?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (32, N'which of the following classes supports developers to get the pointer if a file?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (33, N'which of the following is the correct syntax for suggesting that the JVM performs garbage collection?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (34, N'when creating your own class and you want to make it directly support sorting, which interface must it implement?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (35, N'Which of the following statements is true?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (36, N'which of the following is true about Wrapped classes?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (37, N'Which of the following methods of the java.io.File can be used to create a new file?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (38, N'which of the following modifiers does not allow a variable to be modified its value once it was initialized?', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (39, N'select the most correct statement:', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (40, N'Select correct statement', NULL, 1, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (41, N'the ability of a programming language to process objects differently depending on their type is', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (42, N'Select a correct statement about interfaces', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (43, N'Select the most correct statement', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (44, N'interfaces cannot extend ...... . but they can extend......', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (45, N'____ allows an operation to have different behavior on different objects', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (46, N'which of the following may be declared final?', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (47, N'what method of the java.io.File class can create a file on the hard drive?', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (48, N'a(n) ____ is a characteristic that describes an object', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (49, N'which of the following may appear on the left-hand side of an instanceof operator?', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (50, N'all the method of the ___ class are static', NULL, 2, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (51, N'In order for objects in a List to be sorted, those object must implement which interface and method?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (52, N'which of these class is used to read characters in a file?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (53, N'which of the following may override a method whose signature is void xyz(float f)?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (54, N'in which stream, data unit is primitive data type or string?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (55, N'____ is the process of identifying and grouping attributes and actions related to a particular entity as relevant to the application at hand', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (56, N'suppose prim is an int and wrapped is an Interger. Which of the following are legal Java statements?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (57, N'which of the following keywords can be applied to the variables or methods of an interface ?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (58, N'when you compile a program written in the Java programming language, the compiler converts the human-readable source file info platform-independent code that a Java Virtual Machine can understand. What is this platform-independent code called?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (59, N'The java.util.Vector class provides storage for object references in the order of addition and automatically expands as needed. Which of the following classes is closest in function to the Vector class?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (60, N'Given a string constructed by calling s = new String("xyzzy"), which of the calls modifies the string?', NULL, 3, N'PRO192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (61, N'In C, correct order(s) of a function implementation:', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (62, N'Once the function ends, the control is returned back to the ... function and execution continues from the statement immediately after the function call', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (63, N'When does the code block following while(x<100) execute?', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (64, N'Using break statement we can exit from', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (65, N'Which one of the following is a variable, which can contain the address of the memory location of another variable?', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (66, N'How is a variable accessed from another file?', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (67, N'What value will x contain in the sample code below?
int x=011|0x10;', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (68, N'Which of the following can be used to append one string at the end of another', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (69, N'According to the standard C specification, what are the respective minimum sizes (in bytes) of the following two data type: int and long?', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (70, N'Which one of the following is a valid function definition?', NULL, 1, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (71, N'The operation between float and int would give the result as', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (72, N'The precedence of operators is ___', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (73, N'Evaluate the following as true or false: !(1&&0||!1)', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (75, N'Which of the following is the Boolean operator for logical-and ?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (76, N'What is required to avoid falling through from one case to the next ?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (77, N'What is size of an int ?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (78, N'If the program completes executing successfully, what value should the function main returned?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (79, N'Which of the following adds ones string to the end of another?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (80, N'Which one is not the standard library in C?', NULL, 2, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (81, N'Which of the following functions compares two strings ?', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (82, N'Which of the following is used to call a function named as doFun()', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (83, N'By default any real number is treated as', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (84, N'The ___ function after accepting a character and wait for the Enter key to be pressed.', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (85, N'Which is not a loop structure in C ?', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (86, N'Which of the following data type occupied 1 byte ?', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (87, N'Once the function ends, the control is returned back to the ... function and execution continues from the statement immediately after the function call', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (88, N'Data is stored in computer memory in .........', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (89, N'Which of these statements about fundamental unit in CPU is true?', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (90, N'Comments of a program ...... is wrong.', NULL, 3, N'PRF192', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (91, N'Which of the following is one of the Behavioral Design Patterns?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (92, N'Which of the following statements related to the Generic Method is True?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (93, N'Which of the following is the benefit of Concurrency?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (94, N'Which is keyword meaning access is limited to the current assembly or types derived from the defining class in the current assembly?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (95, N'Which of the following is one of the Gang of Four (GoF) patterns categories?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (96, N'Which of the following statement is one of the core components of the .NET Framework integral to any application or service development?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (97, N'The first character of an identifier (variable) can not be:', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (98, N'Which of the following keywords meaning access is limited in the same assembly but not outside the assembly?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (99, N'In Visual Studio, which utility is used to show all files in the project and to remove a project out of in the solution?', NULL, 1, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (100, N'Which of the following is one of the Creational Design Patterns?', NULL, 1, N'PRN211', 1)
GO
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (101, N'Which the following query operators can use to calculate the sum of the elements in the expression?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (103, N'In Visual Studio, which utility is used to view: namespaces, classes, methods of the assemblies?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (104, N'Which of the following statements related to Constraints on Type Parameters in Generic is True?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (105, N'Which is a definition of a static method?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (106, N'Which of the following keywords is used to extend or modify the abstract or virtual implementation of an inherited method, property, or event?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (107, N'Which of the following keywords is used to override (hidden) an existing method (must not virtual method) of the base class?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (108, N'Which information is correct about the reference types?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (109, N'Which is keyword meaning access is limited to the current assembly or types derived from the defining class in the current assembly?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (110, N'Which of the following is one of the Creational Design Patterns?', NULL, 2, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (111, N'Choose the correct statement related to the Namespaces in C#?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (112, N'Which of the following is one of the Behavioral Design Patterns?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (113, N'The first character of an identifier (variable) can not be:', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (114, N'Which of the following is the Issue of Concurrency?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (115, N'To read a line from the command line window (console window), which of the following statements should be used?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (116, N'Which of the following keywords is used to extend or modify the abstract or virtual implementation of an inherited method, property, or event?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (117, N'Choose the incorrect statement about the delegate.', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (118, N'Which the following query operators can use to calculate the sum of the elements in the expression?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (119, N'In Visual Studio, which utility is used to show all files in the project and to remove a project out of in the solution?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (120, N'Which of the following is one of the Gang of Four (GoF) patterns categories?', NULL, 3, N'PRN211', 1)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (121, N'Write about your hobby', NULL, 1, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (122, N'Write about your ideal lover in future', NULL, 2, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (123, N'Write about your plan for future', NULL, 3, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (124, N'Write about your favorite season', NULL, 2, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (125, N'Write about your dream', NULL, 3, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (126, N'Write about your pet', NULL, 1, N'ENW392', 2)
INSERT [dbo].[Question] ([Id], [Content], [Image], [Level], [SubjectCode], [Type]) VALUES (127, N'What is the most important thing in the research documents?', NULL, 1, N'ENW392', 2)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (1, N'Comparable interface its compare method', 31, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (2, N'Comparable interface its compareTo method', 31, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (3, N'Comparable interface its equals method', 31, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (4, N'Compare interface its compareTo method', 31, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (5, N'java.io.FileStream', 32, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (6, N'java.io.File', 32, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (7, N'java.io.RandomAccessFile', 32, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (8, N'java.io.FileInputStream', 32, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (9, N'System.free();', 33, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (10, N'System.setGarbageCollection();', 33, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (11, N'System.gc();', 33, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (12, N'System.out.gc();', 33, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (13, N'Comparable', 34, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (14, N'Sortator', 34, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (15, N'Sortable', 34, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (16, N'Comparator', 34, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (17, N'A final object''s data cannot be changed', 35, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (18, N'A final class can be subclassed', 35, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (19, N'A final method cannot be overloaded
', 35, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (20, N'A final object cannot ve reassigned a now address in memory', 35, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (21, N'Wrapper classes are: Boolean, Char, Byte, Short, Integer, Long, Float, and Double', 36, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (22, N'Wrapper classes are: Boolean, Character, Byte, Integer, Long, Float, and Double', 36, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (23, N'Wrapper classes are classes that allow primitive types to be accessed as objects', 36, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (24, N'newFile()', 37, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (25, N'There is no such method. Just do File f = new File ("filename.txt"); then the newfile, named filename.txt will be created', 37, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (26, N'createNewFile()', 37, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (27, N'makeNewFile()', 37, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (28, N'transient', 38, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (29, N'final', 38, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (30, N'private', 38, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (31, N'static', 38, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (32, N'A protected method may only be accessed by classes or interfaces of the same package', 39, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (33, N'A protected method may only be accessed by classes of the same package or by subclasses of the class in which it is declared', 39, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (34, N'A protected method may only be accessed by the class in which it is declared or by the subclasses of that class', 39, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (35, N'A protected method may only be accessed by classes or interfaces of the same package or by subclasses of the class in which it is declared', 39, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (36, N'String objects are constants. StringBuffer objects are not', 40, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (37, N'StringBuffer objects are constants. String objects are not', 40, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (38, N'Both String and StringBuffer pbject are constants
', 40, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (39, N'Both String and StringBuffer pbject are not constants', 40, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (40, N'Inheritance', 41, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (41, N'Overloading
', 41, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (42, N'Polymorphism', 41, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (43, N'Astraction', 41, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (44, N'Encapsulation', 41, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (45, N'Overriding', 41, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (46, N'An interface is a class that has method implementations with no data', 42, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (47, N'An interface is an abstract class with no date', 42, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (48, N'In its most common form, an interface is a group of related methods with empty bodies', 42, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (49, N'An interface is a class that has at least one abstract method', 42, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (50, N'If a checked exception may be thrown within the body of a method, the method must catch the exception', 43, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (51, N'If a checked exception may be thrown within the body of a method, the method must declare it in its throwns clause', 43, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (52, N'If a checked exception may be thrown within the body of a method, the method must either catch the exception or declare it in its throws clause', 43, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (53, N'If a checked exception may be thrown within the body of a method, the method mus tcatch the exception and eclare it in its throws clause', 43, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (54, N'classes, interfaces', 44, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (55, N'classes, objects', 44, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (56, N'interfaces, classes', 44, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (57, N'Polymorphism', 45, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (58, N'Encapsulation', 45, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (59, N'Destruction', 45, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (60, N'Construction', 45, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (61, N'Inheritance', 45, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (62, N'Persistence', 45, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (63, N'Methods', 46, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (64, N'Classes', 46, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (65, N'Interfaces', 46, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (66, N'makeNewFile()', 47, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (67, N'newFile()', 47, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (68, N'makerFile()', 47, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (69, N'createFile()', 47, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (70, N'reateNewFile()', 47, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (71, N'attribute', 48, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (72, N'Method', 48, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (73, N'Message', 48, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (74, N'Operation', 48, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (75, N'Event', 48, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (76, N'A class', 49, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (77, N'An interface', 49, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (78, N'A reference', 49, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (79, N'A variable of primitive type', 49, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (80, N'String', 50, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (81, N'Math', 50, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (82, N'System', 50, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (83, N'Runtime', 50, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (84, N'Comparable interface and its compareTo method', 51, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (85, N'Comparable interface and its compare method', 51, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (86, N'Comparable interface and its equals method', 51, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (87, N'Compare interface and its CompareTo method', 51, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (88, N'FileReader', 52, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (89, N'InputStreamReader', 52, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (90, N'FileInputStream', 52, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (91, N'FileWriter', 52, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (92, N'public int xyz(float f)', 53, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (93, N'public void xyz(float f)', 53, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (94, N'private int xyz(float f)', 53, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (95, N'private void xyz(float f)', 53, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (96, N'Binary high-level stream', 54, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (97, N'Binary low-level stream', 54, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (98, N'Character stream', 54, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (99, N'Object stream', 54, 0)
GO
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (100, N'Persistence', 55, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (101, N'Construction', 55, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (102, N'Polymorphism', 55, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (103, N'Data abstraction', 55, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (104, N'Inheritance', 55, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (105, N'Encapsulation', 55, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (106, N'prim = new Integer(9);', 56, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (107, N'All the others', 56, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (108, N'prim = wrapped;', 56, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (109, N'wrapped = prim;', 56, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (110, N'wrapped = 9;', 56, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (111, N'public', 57, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (112, N'static', 57, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (113, N'Depends on the particular implementation of the Java Virtual Machine
', 57, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (114, N'private', 57, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (115, N'protected', 57, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (116, N'inner', 57, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (117, N'binary code', 58, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (118, N'machine code', 58, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (119, N'bytecode', 58, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (120, N'cpu instruction', 58, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (121, N'java.util.LinkedList', 59, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (122, N'java.util.ArrayList', 59, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (123, N'java.util.Hashtable', 59, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (124, N'java.util.List', 59, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (125, N's.substring(3);', 60, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (126, N's.trim();', 60, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (127, N's.replace(''z'', ''a'');', 60, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (128, N's.concat(s);', 60, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (129, N'None of the others', 60, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (130, N's.append("aaa");', 60, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (131, N'Return type, body, function name, parameters', 61, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (132, N'Return type, body, parameters, function name', 61, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (133, N'Return type, function name, parameters, body', 61, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (134, N'Return type, parameters, body, function name', 61, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (135, N'executing', 62, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (136, N'called', 62, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (137, N'declared', 62, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (138, N'calling', 62, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (139, N'when x is less than one hundred', 63, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (140, N'when x is equal to one hundred', 63, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (141, N'when x is greater than one hundred', 63, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (142, N'while it wishes', 63, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (143, N'for a loop', 64, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (144, N'an if statement', 64, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (145, N'the main() function', 64, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (146, N'a program', 64, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (147, N'string', 65, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (148, N'struct', 65, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (149, N'array', 65, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (150, N'pointer', 65, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (151, N'the global variable is referenced via the extern specifier', 66, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (152, N'the global variable is referenced via the pointer specifier', 66, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (153, N'the global variable is referenced via the ext specifier', 66, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (154, N'the global variable is referenced via the global specifier', 66, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (155, N'27', 67, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (156, N'19', 67, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (157, N'25', 67, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (158, N'13', 67, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (159, N'3', 67, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (160, N'strcpy', 68, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (161, N'strcmp', 68, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (162, N'strcat', 68, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (163, N'none of the above', 68, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (164, N'2,8', 69, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (165, N'4,8', 69, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (166, N'2,4', 69, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (167, N'2,2', 69, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (168, N'double funct(int a,b, double c,d)', 70, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (169, N'double funct(int a,b, double c)', 70, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (170, N'double funct(char a,b, double d)', 70, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (171, N'double funct(int a,int b, double c)', 70, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (172, N'float', 71, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (173, N'int', 71, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (174, N'unsigned int', 71, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (175, N'none of the above', 71, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (176, N'Arithmetic, Comparison, Logical', 72, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (177, N'Logical, Comparison, Arithmetic', 72, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (178, N'Comparison, Arithmetic, Logical', 72, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (179, N'Comparison, Logical, Arithmetic', 72, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (180, N'true', 73, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (181, N'false', 73, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (182, N'Invalid expression', 73, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (183, N'&&', 75, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (184, N'|', 75, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (185, N'&', 75, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (186, N'|&', 75, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (187, N'break;', 76, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (188, N'stop;', 76, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (189, N';', 76, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (190, N'end;', 76, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (191, N'8 bits', 77, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (192, N'16 bits', 77, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (193, N'Dependent on machine''s "word" size', 77, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (194, N'32 bits', 77, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (195, N'void', 78, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (196, N'0', 78, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (197, N'nothing', 78, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (198, N'1', 78, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (199, N'stradd();
', 79, 0)
GO
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (200, N'append();', 79, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (201, N'strcat();', 79, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (202, N'stringadd();', 79, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (203, N'time.h
', 80, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (204, N'stdlib.h', 80, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (205, N'system.h', 80, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (206, N'math.h', 80, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (207, N'compare();', 81, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (208, N'stringcompare();', 81, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (209, N'cmp();', 81, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (210, N'strcmp();', 81, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (211, N'Call foFunc();', 82, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (212, N'doFunc();', 82, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (213, N'include doFunc();', 82, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (214, N'None of other choices', 82, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (215, N'a long double', 83, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (216, N'a double', 83, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (217, N'depends upon the memory model that you are using', 83, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (218, N'a float', 83, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (219, N'putch()', 84, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (220, N'putchar()', 84, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (221, N'getch()', 84, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (222, N'getchar()', 84, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (223, N'while', 85, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (224, N'for', 85, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (225, N'do while', 85, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (226, N'repeat until', 85, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (227, N'unsigned char', 86, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (228, N'short', 86, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (229, N'float', 86, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (230, N'long double', 86, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (231, N'double', 86, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (232, N'executing', 87, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (233, N'called', 87, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (234, N'declared', 87, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (235, N'calling', 87, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (236, N'decimal format.
', 88, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (237, N'hexadecimal format.', 88, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (238, N'octal format.', 88, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (239, N'binary format.', 88, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (240, N'The natural unit of the CPU is a int', 89, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (241, N'The natural unit of the CPU is a numeric', 89, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (242, N'The natural unit of the CPU is a bit', 89, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (243, N'The natural unit of the CPU is a word', 89, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (244, N'The natural unit of the CPU is a byte', 89, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (245, N'are used for documenting a program.', 90, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (246, N'are omitted by the compiler.', 90, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (247, N'enhance the readability of a program.', 90, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (248, N'are translated into instructions after the program is compiled.', 90, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (249, N'Facade', 91, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (250, N'Chain of repository', 91, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (251, N'Abtract Factory', 91, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (252, N'Bridge', 91, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (253, N'A method declared with the type parameters for its return type or parameters is called a generic method', 92, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (254, N'Generic methods can only be used to static methods', 92, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (255, N'None of the others', 92, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (256, N'Generic methods can not be defined within non-generic classes', 92, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (257, N'Running of multiple applications: It enables to run of multiple applications at the same time', 93, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (258, N'None of the others', 93, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (259, N'Starvation: It occurs when a process does not obtain service to progress', 93, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (260, N'Deadlock: It occurs when two processes are blocked and hence neither can proceed to execute', 93, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (261, N'internal', 94, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (262, N'private', 94, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (263, N'protected internal', 94, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (264, N'public', 94, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (265, N'All of the others', 95, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (266, N'Structural', 95, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (267, N'Creational', 95, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (268, N'Behavioral', 95, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (269, N'Custom Assemblies', 96, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (270, N'None of the others', 96, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (271, N'Microsoft Intermediate Language (MSIL)', 96, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (272, N'NET Framework Class Library (FCL)', 96, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (273, N'An underscore character', 97, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (274, N'An uppercase letter', 97, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (275, N'A digit', 97, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (276, N'A lowercase letter', 97, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (277, N'public', 98, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (278, N'private', 98, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (279, N'protected internal', 98, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (281, N'internal', 98, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (282, N'Solution Viewer', 99, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (283, N'Class Viewer', 99, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (284, N'Object Viewer', 99, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (285, N'Code Viewer', 99, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (286, N'Adapter', 100, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (287, N'Singleton', 100, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (288, N'All of the others
', 100, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (289, N'Decorator', 100, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (290, N'All of the others', 101, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (291, N'SumAll', 101, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (292, N'Sum', 101, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (293, N'SumWhile', 101, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (294, N'Object Browser', 103, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (295, N'Code Browser', 103, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (296, N'Solution Viewer', 103, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (297, N'Class Viewer', 103, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (298, N'All of the others', 104, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (299, N'Constraints are specified by using the new contextual keyword', 104, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (300, N'Constraints inform the compiler about the capabilities a type argument must have', 104, 0)
GO
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (301, N'Without any constraints, the type argument could be default is an integer type', 104, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (302, N'public void MethodA()', 105, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (303, N'private static MethodA()', 105, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (304, N'public static MethodA()', 105, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (305, N'public static void MethodA()', 105, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (306, N'sealed', 106, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (307, N'abstract', 106, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (308, N'virtual', 106, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (309, N'override', 106, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (310, N'virtual', 107, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (311, N'hidden', 107, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (312, N'override', 107, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (313, N'new', 107, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (314, N'Allocated on the managed data', 108, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (315, N'Can be quickly removed from memory once they fall out of the defining scope', 108, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (316, N'Allocated on the stack', 108, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (317, N'Allocated on the managed heap', 108, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (318, N'internal', 109, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (319, N'protected internal', 109, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (320, N'public', 109, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (321, N'private', 109, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (322, N'Decorator', 110, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (323, N'Singleton', 110, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (324, N'Adapter', 110, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (325, N'All of the others', 110, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (326, N'All of the others', 111, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (327, N'It helps to control the scope of methods and variables in larger .Net programming projects', 111, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (328, N'It is used to organize the classes', 111, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (329, N'The members of a namespace can be interfaces, structures, and delegates but not namespaces', 111, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (330, N'Bridge', 112, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (331, N'Abstract Factory', 112, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (332, N'Facade', 112, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (333, N'Chain of responsibility', 112, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (334, N'An underscore character', 113, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (335, N'A lowercase letter', 113, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (336, N'An uppercase letter', 113, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (337, N'A digit', 113, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (338, N'Blocking: Processes can block waiting for resources. A process could be blocked for a long period waiting for input from a terminal', 114, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (339, N'Average response time: Without concurrency, each application has to be run to completion before the next one can be run', 114, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (340, N'None of the others', 114, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (341, N'Resource utilization: It enables that the resources that are unused by one application can be used for other applications', 114, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (342, N'System.Read.ReadLine();', 115, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (343, N'System.Console.WriteLine();', 115, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (344, N'System.ReadLine();', 115, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (345, N'System.Console.ReadLine();', 115, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (346, N'abstract', 116, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (347, N'override', 116, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (348, N'sealed', 116, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (349, N'virtual', 116, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (350, N'A delegate cannot use with event', 117, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (351, N'Delegates are of reference types', 117, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (352, N'Delegates are used to invoke methods that have the same signatures', 117, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (353, N'Delegates are type-safe', 117, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (354, N'SumWhile', 118, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (355, N'Sumc', 118, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (356, N'SumAll', 118, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (357, N'All of the others', 118, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (358, N'Class Viewer', 119, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (359, N'Solution Viewer', 119, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (360, N'Object Viewer', 119, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (361, N'Code Viewer', 119, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (362, N'Creational', 120, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (363, N'All of the others', 120, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (364, N'Behavioral', 120, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (365, N'Structural', 120, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (366, N'Reality', 127, 1)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (367, N'Statistic', 127, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (368, N'Logical image', 127, 0)
INSERT [dbo].[Answer] ([Id], [Content], [QuestionId], [isCorrect]) VALUES (369, N'Clear scope', 127, 0)
SET IDENTITY_INSERT [dbo].[Answer] OFF
GO
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A1', N'10A1')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A111', N'10A111')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A2', N'10A2')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A3', N'10A3')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A4', N'10A4')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10A5', N'10B1')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'10E', N'10 Engish')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11A1', N'11A1')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11D1', N'11D1')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11D2', N'11D2')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11D3', N'11D3')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11G', N'11 Geography')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'11L', N'11 Literature')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12A1', N'12A1')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12B', N'12 Biology')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12C', N'12 Chemistry')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12H', N'12 History')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12M', N'12 Mathematics')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'12P', N'12 Physics')
INSERT [dbo].[Class] ([ClassCode], [ClassName]) VALUES (N'SE1517', N'SE1517_NET')
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (1, N'Bùi Đức Trung', N'trungbd                                 ', CAST(N'2001-05-05' AS Date), N'HE150245', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (2, N'Nguyễn Quế Tiến', N'tiennq                                  ', CAST(N'2001-03-05' AS Date), N'HE153125', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (3, N'Nguyễn Mạnh Quý', N'quynm                                   ', CAST(N'2001-04-06' AS Date), N'HE153283', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (4, N'Trương Chí Lâm', N'lamtc                                   ', CAST(N'2001-07-20' AS Date), N'HE153301', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (5, N'Nguyễn Khánh Huy', N'huynk                                   ', CAST(N'2001-11-10' AS Date), N'HE153585', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (6, N'Bùi Ngọc Sơn', N'sonbn                                   ', CAST(N'2001-11-23' AS Date), N'HE153647', N'SE1517')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (7, N'Nguyễn Việt Anh', N'anhnv                                   ', CAST(N'2001-01-02' AS Date), N'HE141491', N'10A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (8, N'Nguyễn Thanh Tùng', N'tungnt                                  ', CAST(N'2001-04-18' AS Date), N'HE150190', N'11D2')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (9, N'Bùi Trung Kiên', N'kienbt                                  ', CAST(N'2001-12-12' AS Date), N'HE150611', N'11G')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (10, N'Khiếu Vinh An', N'ankv                                    ', CAST(N'2001-08-09' AS Date), N'HE150757', N'12M')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (11, N'Bùi Đức Anh', N'anhbd                                   ', CAST(N'2001-08-15' AS Date), N'HE151175', N'12P')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (12, N'Từ Minh Quang', N'quangtm                                 ', CAST(N'2000-03-16' AS Date), N'HE151445', N'12C')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (13, N'Nguyễn Văn Quang', N'quangnv                                 ', CAST(N'2001-10-13' AS Date), N'HE153169', N'12H')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (14, N'Bùi Quý Đăng', N'dangbq                                  ', CAST(N'2001-02-11' AS Date), N'HE153275', N'10E')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (15, N'Nguyễn Xuân Nghĩa', N'nghianx                                 ', CAST(N'2001-01-20' AS Date), N'HE153281', N'10A4')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (16, N'Duy Hải Anh', N'anhdh                                   ', CAST(N'1999-05-13' AS Date), N'HE130101', N'11A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (17, N'Đỗ Khắc Trung', N'trungdk                                 ', CAST(N'1999-08-28' AS Date), N'HE130424', N'12B')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (18, N'Đoàn Đức Anh', N'anhdd                                   ', CAST(N'1999-06-22' AS Date), N'HE130460', N'11L')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (19, N'Vũ Phương Thảo', N'thaopv                                  ', CAST(N'1999-09-19' AS Date), N'HE130635', N'12A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (20, N'Hoàng Minh Tiến', N'tienhm                                  ', CAST(N'1999-03-14' AS Date), N'HE130651', N'11D3')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (22, N'Ngô Việt Anh', N'anhnv                                   ', CAST(N'1999-08-30' AS Date), N'HE130715', N'10A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (23, N'Nguyễn Thành Long', N'longnt                                  ', CAST(N'2000-04-14' AS Date), N'HE140165', N'11D2')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (25, N'Lê Bảo Long', N'longlb                                  ', CAST(N'2000-05-30' AS Date), N'HE140604', N'11G')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (26, N'Hoàng Đức Anh', N'anhhd                                   ', CAST(N'2000-07-04' AS Date), N'HE141071', N'12M')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (27, N'Phạm Thái Hoàng', N'hoangpt                                 ', CAST(N'2000-01-26' AS Date), N'HE141158', N'12P')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (28, N'Nguyễn Đức Thịnh', N'thinhnd                                 ', CAST(N'2000-03-28' AS Date), N'HE141433', N'12C')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (29, N'Nguyễn Trùng Dương', N'duongnt                                 ', CAST(N'2000-04-07' AS Date), N'HE141567', N'12H')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (30, N'Vũ Huy Duong', N'duongvh                                 ', CAST(N'2000-11-15' AS Date), N'HE141747', N'10E')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (31, N'Bạch Văn Anh', N'anhbv                                   ', CAST(N'2000-12-01' AS Date), N'HE141759', N'10A4')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (32, N'Đặng Tiến Đạt', N'datdt                                   ', CAST(N'2001-07-14' AS Date), N'HE151528', N'11A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (33, N'Phạm Thanh Long', N'longpt                                  ', CAST(N'2001-08-03' AS Date), N'HE153724', N'12B')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (34, N'Phạm Quỳnh Anh', N'anhpq                                   ', CAST(N'2001-04-16' AS Date), N'HS150134', N'11L')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (35, N'Phạm Thu An', N'anpt                                    ', CAST(N'2004-01-15' AS Date), N'HA151240', N'12A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (36, N'Trần Phương Anh', N'anhtp                                   ', CAST(N'2001-01-03' AS Date), N'HS153241', N'11D3')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (37, N'Thái Trà My', N'mytt                                    ', CAST(N'2001-06-06' AS Date), N'AI151282', N'10A1')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (38, N'Đỗ Như Quỳnh', N'quynhdn                                 ', CAST(N'2000-08-16' AS Date), N'HS150024', N'11D2')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (39, N'Đào Huyền Trang', N'trangdh                                 ', CAST(N'2001-05-04' AS Date), N'HS150049', N'11G')
INSERT [dbo].[Student] ([Id], [FullName], [Password], [Dob], [StudentCode], [ClassCode]) VALUES (40, N'Nguyễn Diệu Anh', N'anhnd                                   ', CAST(N'2001-12-15' AS Date), N'HS150051', N'12M')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Test] ON 

INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (5, N'PRN211_Test1', CAST(N'10:00:00' AS Time), CAST(N'11:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (6, N'PRF192_FE', CAST(N'15:30:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'2022-01-31' AS Date), CAST(N'00:50:00' AS Time), N'PRF192', CAST(N'2022-01-15T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (7, N'PRO192_PT2', CAST(N'09:00:00' AS Time), CAST(N'10:30:00' AS Time), CAST(N'2022-03-01' AS Date), CAST(N'00:30:00' AS Time), N'PRO192', CAST(N'2022-02-28T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (8, N'ENW392_PT1', CAST(N'12:20:00' AS Time), CAST(N'13:50:00' AS Time), CAST(N'2022-03-30' AS Date), CAST(N'01:30:00' AS Time), N'ENW392', CAST(N'2022-03-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (9, N'ENW392_PT2', CAST(N'07:30:00' AS Time), CAST(N'09:00:00' AS Time), CAST(N'2022-02-20' AS Date), CAST(N'01:30:00' AS Time), N'ENW392', CAST(N'2022-02-19T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (10, N'ENW392_PT3', CAST(N'07:30:00' AS Time), CAST(N'09:00:00' AS Time), CAST(N'2022-03-05' AS Date), CAST(N'01:30:00' AS Time), N'ENW392', CAST(N'2022-03-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (11, N'PRN211_FE', CAST(N'10:50:00' AS Time), CAST(N'12:20:00' AS Time), CAST(N'2022-01-31' AS Date), CAST(N'00:50:00' AS Time), N'PRN211', CAST(N'2022-01-15T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (12, N'PRN211_Demo1', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (13, N'PRN211_Demo2', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (14, N'PRN211_Demo3', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (15, N'PRN211_Demo4', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (16, N'PRN211_Demo5', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (17, N'PRN211_Demo6', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (18, N'PRN211_Demo7', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (19, N'PRN211_Demo8', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (20, N'PRN211_Demo9', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (21, N'PRN211_Demo10', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (22, N'PRN211_Demo11', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (23, N'PRN211_Demo12', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (24, N'PRN211_Demo13', CAST(N'08:00:00' AS Time), CAST(N'09:30:00' AS Time), CAST(N'2022-03-15' AS Date), CAST(N'01:00:00' AS Time), N'PRN211', CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (25, N'PRF192_PT2', CAST(N'10:50:00' AS Time), CAST(N'11:20:00' AS Time), CAST(N'2022-03-07' AS Date), CAST(N'00:30:00' AS Time), N'PRF192', CAST(N'2022-03-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (26, N'PRO192_FE', CAST(N'14:20:00' AS Time), CAST(N'15:20:00' AS Time), CAST(N'2022-03-17' AS Date), CAST(N'01:00:00' AS Time), N'PRO192', CAST(N'2022-03-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (27, N'SWT301_ME', CAST(N'09:10:00' AS Time), CAST(N'09:55:00' AS Time), CAST(N'2022-03-05' AS Date), CAST(N'00:45:00' AS Time), N'SWT301', CAST(N'2022-02-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (28, N'SWT301_PT1', CAST(N'11:10:00' AS Time), CAST(N'11:40:00' AS Time), CAST(N'2022-02-15' AS Date), CAST(N'00:30:00' AS Time), N'SWT301', CAST(N'2011-02-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Test] ([Id], [Code], [StartTime], [EndTime], [TestDate], [Duration], [SubjectCode], [CreateDate], [Review]) VALUES (34, N'ENW392_Trial', CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'2022-01-17' AS Date), CAST(N'03:00:00' AS Time), N'ENW392', CAST(N'2022-01-01T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
SET IDENTITY_INSERT [dbo].[Submission] ON 

INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (1, 5, 1, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:30:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (2, 5, 2, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:25:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (3, 5, 3, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:37:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (4, 5, 4, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:45:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (5, 5, 5, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (6, 5, 6, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:43:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (7, 5, 7, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:24:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (8, 5, 22, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:12:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (9, 5, 37, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:35:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (10, 6, 1, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (11, 6, 2, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:40:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (12, 6, 3, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:32:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (13, 6, 4, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (14, 6, 5, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:17:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (15, 6, 6, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:28:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (16, 7, 1, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:28:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (17, 7, 2, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:21:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (18, 7, 3, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (19, 7, 4, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:26:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (20, 7, 5, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:19:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (21, 7, 6, CAST(N'2022-03-01T00:00:00.000' AS DateTime), CAST(N'00:30:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (22, 8, 7, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'00:45:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (23, 8, 22, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'01:10:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (24, 8, 37, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'01:02:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (25, 9, 1, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:45:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (26, 9, 2, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:52:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (27, 9, 3, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:30:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (28, 9, 4, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:35:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (29, 9, 5, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'01:05:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (30, 9, 6, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:38:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (31, 9, 19, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'01:06:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (32, 9, 35, CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'00:34:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (33, 11, 19, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:32:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (34, 11, 35, CAST(N'2022-01-31T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (35, 12, 1, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'01:00:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (36, 12, 2, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:44:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (37, 12, 3, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:33:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (38, 12, 4, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (39, 12, 5, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:24:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (40, 12, 6, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:55:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (41, 12, 10, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (42, 12, 26, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:37:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (43, 12, 40, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (44, 13, 18, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:28:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (45, 13, 34, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:32:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (46, 14, 18, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (47, 14, 34, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (48, 16, 18, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:34:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (49, 16, 34, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:43:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (50, 17, 1, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (51, 17, 2, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:42:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (52, 17, 3, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (53, 17, 4, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:33:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (54, 17, 5, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:25:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (55, 17, 6, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:47:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (56, 19, 10, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:26:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (57, 19, 26, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:19:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (58, 19, 40, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:33:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (59, 22, 1, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:12:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (60, 22, 2, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (61, 22, 3, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:26:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (62, 22, 4, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (63, 22, 5, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:35:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (64, 22, 6, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:48:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (65, 23, 19, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:40:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (66, 23, 35, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:36:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (67, 24, 1, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:26:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (68, 24, 2, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:17:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (69, 24, 3, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (70, 24, 4, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:37:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (71, 24, 5, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (72, 24, 6, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:49:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (73, 24, 19, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (74, 24, 35, CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'00:27:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (75, 25, 1, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (76, 25, 2, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:30:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (77, 25, 3, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (78, 25, 4, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:23:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (79, 25, 5, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:29:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (80, 25, 6, CAST(N'2022-03-07T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (81, 26, 1, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (82, 26, 2, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:45:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (83, 26, 3, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:39:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (84, 26, 4, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:49:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (85, 26, 5, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:50:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (86, 26, 6, CAST(N'2022-03-17T00:00:00.000' AS DateTime), CAST(N'00:55:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (87, 27, 10, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'00:42:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (88, 27, 26, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'00:38:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (89, 27, 40, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'00:22:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (90, 34, 8, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'00:05:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (91, 34, 23, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'00:12:00' AS Time))
INSERT [dbo].[Submission] ([Id], [TestId], [StudentId], [SubmitDate], [Duration]) VALUES (92, 34, 38, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'00:15:00' AS Time))
SET IDENTITY_INSERT [dbo].[Submission] OFF
GO
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 91, 250)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 92, 254)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 93, 259)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 94, 263)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 95, 265)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 96, 269)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 97, 273)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 98, 278)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 99, 285)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 100, 288)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 101, 290)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 103, 297)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 104, 300)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 105, 302)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 106, 308)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 107, 313)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 109, 321)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 110, 322)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 111, 327)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 113, 334)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 114, 339)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 115, 345)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 116, 347)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 117, 350)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (1, 120, 363)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 91, 250)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 92, 254)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 93, 258)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 94, 262)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 95, 266)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 96, 270)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 97, 275)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 98, 278)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 99, 284)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 100, 286)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 101, 290)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 103, 294)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 104, 298)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 105, 305)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 106, 308)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 107, 311)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 109, 321)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 110, 323)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 111, 327)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 113, 335)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 114, 341)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 115, 342)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 116, 347)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 117, 350)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (2, 120, 363)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 91, 250)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 92, 255)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 93, 260)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 94, 264)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 95, 267)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 96, 271)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 97, 274)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 98, 278)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 99, 283)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 100, 287)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 101, 293)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 103, 297)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 104, 298)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 105, 303)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 106, 309)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 107, 311)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 109, 321)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 110, 325)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 111, 327)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 113, 336)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 114, 329)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 115, 342)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 116, 349)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 117, 352)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (3, 120, 363)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 91, 250)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 92, 256)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 93, 258)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 94, 262)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 95, 268)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 96, 272)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 97, 276)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 98, 281)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 99, 282)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 100, 287)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 101, 292)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 103, 295)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 104, 301)
GO
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 105, 303)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 106, 307)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 107, 313)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 109, 321)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 110, 324)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 111, 327)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 113, 334)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 114, 340)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 115, 345)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 116, 348)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 117, 352)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (4, 120, 363)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 91, 250)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 92, 254)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 93, 259)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 94, 263)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 95, 265)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 96, 270)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 97, 273)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 98, 277)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 99, 284)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 100, 289)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 101, 291)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 103, 294)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 104, 300)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 105, 303)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 106, 307)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 107, 312)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 109, 321)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 110, 324)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 111, 329)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 113, 337)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 114, 329)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 115, 344)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 116, 347)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 117, 352)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (5, 120, 363)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 91, 249)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 92, 254)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 93, 258)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 94, 262)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 95, 265)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 96, 272)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 97, 275)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 98, 279)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 99, 282)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 100, 287)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 101, 291)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 103, 296)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 104, 301)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 105, 304)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 106, 306)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 107, 310)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 108, 315)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 109, 319)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 110, 323)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 111, 327)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 112, 333)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 113, 335)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 114, 329)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 115, 345)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 116, 346)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 117, 352)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 118, 356)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 119, 358)
INSERT [dbo].[Submission_QA] ([SubmissionId], [QuestionId], [AswerId]) VALUES (6, 120, 363)
GO
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (5, N'10A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (5, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (6, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (7, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (8, N'10A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (8, N'10A2')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (8, N'10A3')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (8, N'10A4')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (8, N'10A5')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (9, N'12A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (9, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (10, N'10A5')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (10, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (11, N'11G')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (11, N'12A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (12, N'12M')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (12, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (13, N'11D3')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (13, N'11L')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (14, N'11L')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (14, N'12H')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (15, N'10E')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (15, N'11D1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (16, N'11D1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (16, N'11L')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (17, N'12C')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (17, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (18, N'11G')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (18, N'12P')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (19, N'12C')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (19, N'12M')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (20, N'11A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (20, N'11G')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (21, N'10A2')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (21, N'12B')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (22, N'10A3')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (22, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (23, N'10A4')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (23, N'12A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (24, N'12A1')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (24, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (25, N'10A3')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (25, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (26, N'10E')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (26, N'SE1517')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (27, N'10E')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (27, N'12M')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (28, N'10E')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (28, N'12B')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (34, N'11D2')
INSERT [dbo].[Test_Class] ([TestId], [ClassCode]) VALUES (34, N'11G')
GO
SET IDENTITY_INSERT [dbo].[Essay] ON 

INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (1, 34, 8, 121, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'02:30:00' AS Time), N'Hobbies play a very important role in our lives. They occupy our minds when we are free and also make us happy. Hobbies are our escape from the real world that makes us forget our worries. Moreover, they make our lives interesting and enjoyable. If we look at it, all our hobbies are very useful for us. They teach us a lot of things about different stuff. They also help in expanding our knowledge.

Benefits of Having a Hobby
In today’s fast and competitive world, we often get time for ourselves. Over time, our schedule gets very dull and monotonous. That is why we need to indulge in something in between to keep our minds fresh and active. What’s better than a hobby for this? One of the main benefits of having a hobby is that it is a major stress-buster. You actually enjoy doing it and it satisfies your soul.In other words, without a hobby, your life becomes an unhealthy cycle lacking any excitement or spark. Hobbies offer you a great opportunity to take a break and forget the worries of your life. They allow you to explore yourself and realize your potential in different areas.

Moreover, hobbies can also be a source of extra income. For instance, if you like painting, you can actually sell your art to make some extra money. Likewise, if you have a knack for dancing, you may teach dance classes to people on your holidays. This way your hobby a benefit you both spiritually and financially as well.My Favourite Hobby
If I were to pick one favourite hobby of mine out of the many I have, I will definitely pick gardening. I developed a taste for dancing when I was very young. The way my feet moved to the rhythm of the music convinced my parents that I was a born dancer. Dancing is very uplifting as well as economical.

I have always had a love for music and dance. However, I never realized the utter joy they bring to humans. Dancing gives us a lot of exercises. It teaches us to move our body rhythmically and feel the beat of every song. This kind of physical exercise is extremely delightful and enjoyable.

Moreover, dance also taught me how to stay strong and push my limits. I have had many injuries while dancing, too many bruises and cuts but that didn’t stop me from pursuing it further. In fact, it pushes me to do my best and realize my potential more than ever.

I have enrolled in dancing classes because I wish to make my hobby my career. I feel we all should do things which we enjoy doing. Everyone is running after money and in this race, they give up their likings and preferences. I have learned from this race and decided to not take part in it. I wish to take the road less traveled by and take on challenges most people don’t dare to.

In short, my hobby of dancing makes me feel alive and well. It is the only thing I look forward the most to. Thus, I hope to achieve my dream of being a professional dancer and making way for people who wish to make careers out of their hobbies.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (2, 34, 23, 123, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'02:45:00' AS Time), N'Everybody has dreams. Climate they are to turn into a researcher, find new and astonishing things, become a star b-ball player, and be the most generously compensated part in the alliance, individuals long for their future. I have dreams for the future, very much like every other person.

Dreams of easy street, with bunches of cash, hot young ladies, and quick vehicles! Also, I will take the necessary steps to accomplish it. If individuals decide to acknowledge it, we as a whole have a perspective. A perspective is a manner by which we see the world and individuals around us.

A perspective resembles glancing through glasses because an individual’s perspective explains how they see individuals and their general surroundings. An individual’s perspective is the central component that directs their dynamic. Perspectives are a bunch of presuppositions that are not quite the same as individual to individual; however, they are critical to comprehend because they give the premise to our dynamic. It ought to be finished with extraordinary consideration because the accomplishment of life relies on the correct decision.

I was distinctly interested in Biology when I was an understudy in High school. My dad is a specialist since the time of my adolescence. I needed to turn into a specialist to serve humanity. The most important obligation of a specialist is to serve mankind. He ought to have a thoughtful demeanour. A specialist invests his time, energy and ability to bend the wiped out in forestalling sicknesses and mitigating torment. He should be prepared to broaden his administration whenever. Indeed, a specialist is the worker of enduring mankind.

That is the reason for my dad’s recommendation. I have chosen this calling for myself in the light of the above merits, and I am quick to embrace this calling. In the wake of passing Intermediate, I will go to Lucknow to instruct classes for C.P.M.T. I’m certain that I will be chosen in my first endeavour. At that point, I will be conceded to I year class of M.B.B.S. After taking my M.B.B.S level, I will undoubtedly serve in any rustic zone for in any event two years. At that point, I have concluded that I will begin my centre in my town. I aspire to offer help to the feeble individuals and a beam of desire to the disillusioned individuals, and life is the sole right of God. Man can’t offer life to the dead. He can just soothe him from paints. Thus, I will put forth a valiant effort in this field.

I will charge no meeting expense from the needy individuals. Needy individuals who can’t pay cash will get meds liberated from my centre. When seven days I will go to a town. I will analyze the patients complimentary and give them drugs there. I will likewise encourage them to keep their town clean and how they can dispose of illnesses.

Similarly, double every seven days, I will approach individuals and inform them regarding the reasons for various infections and the mystery of good wellbeing. I may connect myself with some friendly association to serve individuals liberated from cost. I have concluded that I will fulfil all the patients with my thoughtful demeanour, polite habits, kind and adoring conduct, sharp perception, testing and the best solution and direction.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (3, 34, 38, 126, CAST(N'2022-01-17T00:00:00.000' AS DateTime), CAST(N'02:50:00' AS Time), N'Pets are a great blessing in anyone’s life. They are the only ones who love us unconditionally. Pets always offer us everything they have without asking for anything in return. The main aim of any pet’s life is to make their owner happy. Nowadays, even the term ‘owner’ is changing. People prefer their pets as kids and to themselves as parents. This is how the relationship between pets is evolving. People treat them no less than humans. For instance, they celebrate their birthdays; get those matching outfits and more.

In my opinion, I feel the pets rightly deserve it. The most common pet you can find at anyone’s place is dogs. A man’s best friend and the most faithful animal, a dog. I also have a pet dog that I love to bits. We got him when he was a little baby and have watched him grow into a beautiful dog. All my family members love him with all their heart. We love his silly antics and cannot imagine our lives without him. We named him Sasha.

Sasha – My Pet Dog
My father adopted Sasha when he was a little baby. His friend had given birth to puppies and they decided to put the puppies up for adoption. We convinced our father to get one for us. Considering they knew our family well, they immediately agreed. Little did we know that our lives would change forever after his entrance.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (4, 8, 7, 124, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'01:30:00' AS Time), N'Just like many other kids my age, I like the summer season the most. What’s not to like about it? You get to enjoy long holidays as everyone gets a break from school. Similarly, parents allow the kids to have ice creams.

Cold drinks are another reasons why summer is my favourite season. We get to have such a wide variety of food items during this season. On the healthier side, we also get incredible mangoes in the summer season.

As mangoes are my favourite fruit, I tend to like summers even more. Summers make us truly appreciate and savour a lot of things. During the summer season, we get holidays for a long time.

During the summer holidays, I get to spend time with my family and friends to the fullest. When we get lucky, we even go on family trips. I look forward to them every year, even if it is a small trip.

Most importantly, there are so many activities that I get to do during summers like joining summer camps, cycling, swimming, and more. Summers are so bright and exciting that it has always been my favourite season.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (5, 8, 22, 124, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'01:15:00' AS Time), N'The summer season has long days and short nights. The days are sunny and bright. We get to relax completely during the afternoons during summers. Similarly, we also get so much sunlight.

The water parks are always full of people during summers that help people stay cool and have a good time. I like swimming in the pools during summers as it makes me feel free. There are also different varieties of food items I get to enjoy during summers.

There are fresh cucumbers, huge watermelons, juicy oranges, sweet guavas, nutritious muskmelons, and more. The early mornings of summer are incredible and nothing can match the atmosphere.

Another speciality of summer has to be the clothes. People enjoy wearing shorts, dresses, sleeveless shirts, and more to enjoy summers to the fullest. The hill stations are swarmed during the summer season as everyone goes there to escape the heat. Therefore, all these specialities make me love summer even more.

Conclusion
All in all, summer is my favourite season as everything is bright and lovely. Even the fruits and vegetables we get are so colourful that it makes a good sight for sore eyes. School going children love summers even more as summer break allows us to play more and relax. Summers are warm, sunny, and delightful.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (6, 8, 37, 124, CAST(N'2022-03-30T00:00:00.000' AS DateTime), CAST(N'01:25:00' AS Time), N'Choosing a favorite season would be difficult because they are all special to me. They each have something to offer and are unique in every way.
             Winter is one of my favorites because it is so beautiful to see everything covered with a white sheet of snow. It also cools you down from all the heat left from the summer and into the fall. You have fun with your family making snow angels and have snowball fights.
             Spring is a good season because it is between winter and summer, temperatures are not too cold and not to hot. You are comfortable wearing a light jacket outside instead of a heavy warm coat. You can walk and smell the flowers beginning to flourish. The birds start chirping early in the morning. It lets you know that summer is near and so is summer vacation.
             Summer is great because it''s time to hang up your shoes and relax. There is no more school and you can go to sleep late and wake up late. Relatives visit or you can visit them. You can also do some traveling and explore new places. Relaxing in the pool on a floating lounge chair enjoying cold lemonade is the ultimate experience.
             Autumn is also a great season because of all the colorful leaves falling even though they are a hassle to pick up, especially in the pools. You can have fun walking with friends and admiring the different shades of colors on the leaves. The different colors warm your soul.
             Autumn is such a calm season. The leaves turn beautiful tones of yellow, orange, and red. Everyone is starting over with a new class, a new teacher, and some new friends. When you drive by the neighborhoods you notice that families are all gathered in some kind of celebration. You get such a warm feeling. It''s such a peaceful time.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (7, 10, 1, 121, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'01:00:00' AS Time), N'My favourite hobby is reading; therefore I have collected various types of books. I started reading fairy tales when I was four years old. At the first time, I was interesting in colorful pictures with meaningful contents. When reading a story with a happy ending, I felt very happy. Reading books brings me a lot of benefit. Firstly, it makes me relaxed and calmed. After a hard-working day, I can relieve stress by reading a funny story. I also learn new vocabulary items. Then I can further improve my English. Moreover, it can give me an unlimited imagination, so I can write books in the future. I can learn the different cultures and customs of other countries in the world too. I read books at least one hour every day. I wish I could read different kinds of books because it might be very challenging.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (8, 10, 2, 121, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'00:45:00' AS Time), N'When I have free time, I usually listen to music. Except school time, music lives with me for almost the rest of the day. I listen to it when I am on the bus, when I do the house chores, or even when I am taking a shower, and whenever I feel like I need it. Music is always a new thing, because it changes each day. Some of my favorite types are Pop, Country, Ballad, and Dance. Each of them gives me a different feeling, so I choose the songs to listen to according to my current mood. I listen to Pop songs when I am comfortable and happy, Country and Ballad is for relaxing, and Dance is for when I want to move my body. Sometimes when I go outside, I just put my playlist on shuffle mode, and it is very interesting not to know about the upcoming song. I do have some of my favorite singers, and I usually download their whole album to my phone. Music helps me to relax, cheer up my mood, and ease my nerves after a long exhausting day. Since it does not take too much of my time, effort and money, I will feel free to consider it as my favorite activity of all time.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (9, 10, 3, 122, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'01:30:00' AS Time), N'We always want to meet a perfect partner in our life that are your girlfriend, your wife, your boyfriend or your husband in the future. Each person has many different details with their partner. I want to love one or two person but one is the best and if not, two is maximum. Then I hope to get married when I am 26 years old. I think this is a suitabe age. My husband has the same age with me or older than me are all right. Comeback our main theme. In my oppinion, about body of my partner, he must taller than me but not too tall, about 170cm is suitable. He dresses nice but isn''t too worried about fashion. Next, he has a good and stable job. The most important is his character. The first, he loves me sincerely, repects me, my hobbies and my family. I want to meet a fun boy, good to talk to and more knowledgeable than me. I hope that because when we talk together we can know more about each other and I can learn more from him. The next, my partner is must friendly, responsible and frank. It will be more easy to share our oppinions if he is a frank person. I also hope he has the same hobbies like me. If not it doesn''t matter because I will respect him as long as we fell comfortable when we stay together. I hope he is as trustworthy as possible because I will talk to him many things about me including my secrets. Last but not least, I want he will be by my side when I have troubles and help me to over come. I will do like that too because he is worthy. I know nobody is perfect but I am looking forward to seeing a good person. Ofcourse, I am must a good girl first and study harder, work harder to deserved with my future partner.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (10, 10, 4, 122, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'01:15:00' AS Time), N'Each person must have the ideal partner for themselves. For me, my ideal partner is a good heart, honesty, and respect parents, hardworking, and educated. Moreover, she is also a pretty and attractive woman.
Firstly, I love my ideal partner very much because she is enough clever to keep my heart cheerful and always helps me when I need her, especially in my studies.
Besides that, my girlfriend is good heart and responsible when she always reminds me that education is very important because that is what determines our future.
Therefore I have to put my education first and when I have problems in studying, we can share with each other to solve together. Last but not least, my woman always respect my parents by greeting them, asking them whenever she helping them in some situations.
For my conclusion, when we want to choose the ideal partner for us, we must know the background of her life and characteristics so that we can choose a suitable lover in the future
')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (11, 10, 5, 123, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'01:25:00' AS Time), N'The word of the future is about all what is mysterious and unknown to man from events and attitudes, which he feels towards the varied and mixed feelings. He is eagerly waiting for the happy events that bring joy to his life , and sometimes he fears of it and has a sense of anxiety and tension about what can be coming, which may be negative, sad and painful.

Some people consider that the future is the mirror of the present and the essence of past experience. Although the future remains unknown , many consider it dependent on them ,and they are the only ones capable of making it happy or unhappy.

Most people in the world plan for their future, and in order to reach goals and dreams, a person must follow several steps, such as: to think calmly in the present and the ways that the individual can walk to achieve his dreams.

Reviewing individual talents, a person who knows his or her own qualities is better able to determine what he wants for the future.

Follow the style of writing lists of completed and intended work.

To remind himself all the time about his dreams so that it remains in his eyes and insists on achieving it and not forget it.

Planning saving money that enables the individual to buy what he wants in the future, such as buying a house or a car and others.

Positive thoughts that push the person forward and in return to reject the negative ideas that discourage the determination of man.')
INSERT [dbo].[Essay] ([Id], [TestId], [StudentId], [QuestionId], [SubmitDate], [Duration], [Content]) VALUES (12, 10, 6, 123, CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'01:00:00' AS Time), N'Imagine the perfect life, the perfect family, dream house, dream car, and the perfect career. That’s what I hope someday my life will be like. Everyone has a future plan, to make the best out of our life, what is your plan? My future plan is to be a pediatrician. I would like to help the children of the future. They are the next generation and I would like to leave a legacy for them to follow. I want to help save and make a child happy someday. The thought of making a difference in someone’s life is the reason I can go to sleep peacefully. We all have a purpose for being here and I my purpose is to save one of us, my purpose is to help the ones in need, the ones in the street begging for somewhere to live, the ones dying of poverty. However, right now in the 21st century technology has taken over the world, not figuratively but literally. It made the world, both a bad and good place. People are going to run out of jobs and tech will run the world. Technology will be the greatest invention of human kind but how will it affect some of us? ')
SET IDENTITY_INSERT [dbo].[Essay] OFF
GO
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (31, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (32, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (33, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (34, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (35, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (36, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (37, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (38, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (39, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (40, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (41, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (42, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (43, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (44, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (45, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (46, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (47, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (48, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (49, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (50, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (51, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (52, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (53, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (54, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (55, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (56, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (57, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (58, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (59, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (60, 7)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (61, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (62, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (63, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (64, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (65, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (66, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (67, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (68, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (69, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (70, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (71, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (72, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (73, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (75, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (76, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (77, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (78, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (79, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (80, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (81, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (82, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (83, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (84, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (85, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (86, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (87, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (88, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (89, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (90, 6)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (91, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (92, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (93, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (94, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (96, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (97, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (98, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (99, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (100, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (101, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (103, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (104, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (105, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (106, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (107, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (108, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (109, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (110, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (111, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (112, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (113, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (114, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (115, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (116, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (117, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (118, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (119, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (120, 5)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (121, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (121, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (121, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (121, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (122, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (122, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (122, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (122, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (123, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (123, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (123, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (123, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (124, 8)
GO
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (124, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (124, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (124, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (125, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (125, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (125, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (125, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (126, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (126, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (126, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (126, 34)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (127, 8)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (127, 9)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (127, 10)
INSERT [dbo].[Question_Test] ([QuestionId], [TestId]) VALUES (127, 34)
GO
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 1, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 2, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 3, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 4, 10, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 5, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 6, 5.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 7, 10, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 22, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (5, 37, 8.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 1, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 2, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 3, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 4, 7.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 5, 8.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (6, 6, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 1, 10, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 2, 4.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 3, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 4, 6.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 5, 6.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (7, 6, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (8, 7, 6.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (8, 22, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (8, 37, 7.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 1, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 2, 10, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 3, 4, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 4, 3.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 5, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 6, 7.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 19, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (9, 35, 8.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (11, 19, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (11, 35, 9.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 1, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 2, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 3, 8.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 4, 4.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 5, 10, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 6, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 10, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 26, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (12, 40, 7.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (13, 18, 7.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (13, 34, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (14, 18, 8.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (14, 34, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (16, 18, 5.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (16, 34, 4.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 1, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 2, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 3, 6.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 4, 6.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 5, 8.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (17, 6, 7.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (19, 10, 8.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (19, 26, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (19, 40, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 1, 8.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 2, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 3, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 4, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 5, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (22, 6, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (23, 19, 7.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (23, 35, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 1, 5.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 2, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 3, 6.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 4, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 5, 8.75, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 6, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 19, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (24, 35, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 1, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 2, 7.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 3, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 4, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 5, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (25, 6, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 1, 4.25, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 2, 6, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 3, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 4, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 5, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (26, 6, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (27, 10, 6.5, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (27, 26, 7, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (27, 40, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (34, 8, 9, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (34, 23, 8, NULL)
INSERT [dbo].[Mark] ([TestId], [StudentId], [Mark], [Note]) VALUES (34, 38, 8.5, NULL)
GO
INSERT [dbo].[Moderator] ([UserName], [FullName], [Password]) VALUES (N'prn211', N'PRN211', N'team3                                                                                               ')
GO
