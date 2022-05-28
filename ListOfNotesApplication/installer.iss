; ��� ����������
#define   Name       "List of Notes"
; ������ ����������
#define   Version    "1.0.0"
; ����������� 
#define   Publisher  "Arseniy Karmanov 571-2"
; ���� ������������
#define   URL        "https://sdo.tusur.ru/user/profile.php?id=19381"
; ��� ������������ ������
#define   ExeName    "ListOfNotesApplication.exe"

;------------------------------------------------------------------------------
;   ��������� ���������
;------------------------------------------------------------------------------
[Setup]

; ���������� ������������� ����������, 
;��������������� ����� Tools -> Generate GUID
AppId={{7FB57294-9FFF-4136-90CE-0001D473C9A7}

; ������ ����������, ������������ ��� ���������
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

; ���� ��������� ��-���������
DefaultDirName={commonpf}\{#Name}
; ��� ������ � ���� "����"
DefaultGroupName={#Name}

; �������, ���� ����� ������� ��������� setup � ��� ������������ �����
OutputDir=.\bin\Release
OutputBaseFileName=ListOfNotes

; ���� ������
SetupIconFile=.\Resources\noted_64.ico

UninstallDisplayIcon={app}\noted_64.ico

; ��������� ������
Compression=lzma
SolidCompression=yes

[Dirs]
Name: {userappdata}\{#Name}

;------------------------------------------------------------------------------
;   ������������� ����� ��� �������� ���������
;------------------------------------------------------------------------------
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl";
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

;------------------------------------------------------------------------------
;   ����������� - ��������� ������, ������� ���� ��������� ��� ���������
;------------------------------------------------------------------------------
[Tasks]
; �������� ������ �� ������� �����
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked


;------------------------------------------------------------------------------
;   �����, ������� ���� �������� � ����� �����������
;------------------------------------------------------------------------------
[Files]

; ����������� ����
Source: ".\bin\Release\ListOfNotesApplication.exe"; DestDir: "{app}"; Flags: ignoreversion

; ������������� �������
Source: ".\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

Source: ".\save_note.json"; DestDir: "{userappdata}\{#Name}"


;------------------------------------------------------------------------------
;   ��������� �����������, ��� �� ������ ����� ������
;------------------------------------------------------------------------------ 
[Icons]

Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"; IconFilename: "{app}\noted_64.ico"

Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; IconFilename: "{app}\noted_64.ico"; Tasks: desktopicon

Name: "{group}\{cm:UninstallProgram,{#Name}}"; Filename: "{uninstallexe}"; IconFilename: "{app}\noted_64.ico"