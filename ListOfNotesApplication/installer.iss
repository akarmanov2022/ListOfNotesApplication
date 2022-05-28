; Имя приложения
#define   Name       "List of Notes"
; Версия приложения
#define   Version    "1.0.0"
; Разработчик 
#define   Publisher  "Arseniy Karmanov 571-2"
; Сафт разработчика
#define   URL        "https://sdo.tusur.ru/user/profile.php?id=19381"
; Имя исполняемого модуля
#define   ExeName    "ListOfNotesApplication.exe"

;------------------------------------------------------------------------------
;   Параметры установки
;------------------------------------------------------------------------------
[Setup]

; Уникальный идентификатор приложения, 
;сгенерированный через Tools -> Generate GUID
AppId={{7FB57294-9FFF-4136-90CE-0001D473C9A7}

; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

; Путь установки по-умолчанию
DefaultDirName={commonpf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}

; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=.\bin\Release
OutputBaseFileName=ListOfNotes

; Файл иконки
SetupIconFile=.\Resources\noted_64.ico

UninstallDisplayIcon={app}\noted_64.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes

[Dirs]
Name: {userappdata}\{#Name}

;------------------------------------------------------------------------------
;   Устанавливаем языки для процесса установки
;------------------------------------------------------------------------------
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl";
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

;------------------------------------------------------------------------------
;   Опционально - некоторые задачи, которые надо выполнить при установке
;------------------------------------------------------------------------------
[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked


;------------------------------------------------------------------------------
;   Файлы, которые надо включить в пакет установщика
;------------------------------------------------------------------------------
[Files]

; Исполняемый файл
Source: ".\bin\Release\ListOfNotesApplication.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: ".\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

Source: ".\save_note.json"; DestDir: "{userappdata}\{#Name}"


;------------------------------------------------------------------------------
;   Указываем установщику, где он должен взять иконки
;------------------------------------------------------------------------------ 
[Icons]

Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"; IconFilename: "{app}\noted_64.ico"

Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; IconFilename: "{app}\noted_64.ico"; Tasks: desktopicon

Name: "{group}\{cm:UninstallProgram,{#Name}}"; Filename: "{uninstallexe}"; IconFilename: "{app}\noted_64.ico"