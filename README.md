//homeworkOOP.Применение принципов ООП: /////////////////////////////////////////////////////////////////////////////////////////////////////////

* Инкапсуляция:
Каждые задача, менеджер задач и хранилище имеют четко определенные границы ответственности, например, класс Task инкапсулирует поля, связанные с состоянием задачи (Id, Description, IsCompleted), и методы для изменения этого состояния.
Прямой доступ к переменным задачи возможен только через методы класса (MarkAsCompleted, ToString).
Все взаимодействие с задачами происходит через интерфейсы и публичные методы, обеспечивая скрытие деталей реализации от внешнего кода.

* Наследование:
IStorage определяет общую структуру хранилища задач, реализации хранилищ наследуют этот интерфейс и реализуют методы загрузки и сохранения задач по-разному, при этом сохраняя единый интерфейс для взаимодействия с ними через менеджер задач.

* Полиморфизм:
Менеджер задач не знает, с каким конкретным типом хранилища он работает (в памяти или на диске), просто вызывает методы через интерфейс, а конкретная реализация отвечает за детали сохранения.
Application создает объекты команд и вызывает метод Execute(), не зная точно, что конкретно будет сделано.

* Абстракция:
IStorage и ICommand — это примеры абстракций, которые позволяют отделить логику работы с хранилищем и выполнения команд от их конкретных реализаций.
Важно, что приложение работает с этими абстракциями, не привязываясь к конкретным реализациям, что позволяет легко изменять поведение программы, заменяя один объект на другой.

//homeworkOOP.Применение паттернов проектирования: //////////////////////////////////////////////////////////////////////////////////////////

* Паттерн Command:
Используется для обработки действий пользователя. Интерфейс ICommand и его реализации представляют собой команды, которые инкапсулируют в себе запросы на выполнение определенных действий, упрощая добавление новых команд.

* Паттерн Factory:
В данной работе фабрика как отдельный класс не используется, но признаки фабричного подхода есть: в методе HandleCommand создаются объекты команд на основе пользовательского ввода, т.е. достаточно добавить обработку новой команды

//homeworkOOP.Применение принципов SOLID: ///////////////////////////////////////////////////////////////////////////////////////////////////////

* SRP:
Класс задач отвечает за хранение данных задачи и управление её состоянием.
TaskModManager управляет набором задач, сохраняя их через хранилище.
MemoryStorageOfKittens и FileStorageOfKittens отвечают за сохранение и загрузку задач в различных местах (память или файл).
Каждый класс команд отвечает за выполнение одного конкретного действия.

* OCP:
Код открыт для расширения, но закрыт для модификации. Например, если нужно добавить новое хранилище, достаточно реализовать интерфейс IStorage, не изменяя код TaskManager. Аналогично, можно добавить новую команду, реализовав интерфейс ICommand, не изменяя другие команды.

* LSP:
Реализации интерфейса IStorage могут быть заменены друг другом, и TaskModManager не будет замечать разницы. То есть, класс менеджера задач может работать с любым объектом, реализующим интерфейс IStorage, не нарушая функциональности.

* ISP:
Интерфейсы IStorage и ICommand имеют только самые необхлдимые методы.

* DIP:
Все зависимости реализованы от интерфейсов, а не конкретных реализаций, что позволяет подменять реалищации без изменений (относительно) внешнего кода.
