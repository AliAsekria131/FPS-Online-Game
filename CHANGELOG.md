# CHANGELOG — FPS Online Game

## [0.3.0] — 2026-11-20

### Added
- `client/scripts/Weapons/Weapon.cs`: سلاح Hitscan بـ RayCast3D + MuzzleFlash.
- `client/scenes/Weapons/Weapon.tscn`: مشهد السلاح (Model + RayCast3D + OmniLight3D).
- إجراء `fire` في Input Map (زر الفأرة الأيسر).
- ربط `Weapon.tscn` بـ `Camera3D` داخل `PlayerController.tscn`.

### Tests
- اختبار محلي: Raycast يصيب الأرضية والجدران، ويطبع نقطة الاصطدام والمتجه الطبيعي. Miss عند التصويب نحو السماء.

## [0.2.0] — 2026-11-20

### Added
- استيراد PolarBears Player Controller إلى `client/addons/player_controller`.
- إعداد Input Map للحركة (`move_forward/back/left/right`, `jump`, `crouch`, `sprint`).
- إنشاء `client/scenes/TestMap.tscn` (أرضية، جدار، إضاءة بدون ظلال).
- اختبار الحركة محلياً: ناجح.

### Technical Decisions
- تعطيل ظلال `DirectionalLight3D` في خريطة الاختبار لتوفير موارد GPU (كرت 128MB).
- الاحتفاظ بمجلد PolarBears `Examples/` كمصدر مرجعي (سيُنظّف في مهمة لاحقة).

## [0.1.0] — 2026-11-20

### Added
- إنشاء هيكل المستودع الأساسي (`shared/`, `client/`, `server/`).
- إضافة ملفات التوثيق: `README.md`, `PROJECT_STATE.md`, `ARCHITECTURE.md`, `THIRD_PARTY_NOTICES.md`, `CHANGELOG.md`, `HANDOFF.md`.
- إضافة `.gitignore` خاص بـ Godot 4+ و .NET.

### Technical Decisions
- اعتماد Godot 4.7.2 Mono و .NET 8 SDK.
- اعتماد بنية ثلاثية: `FPS.Shared` (مكتبة) + `FPS.Client` (Godot) + `FPS.Server` (Godot).
- اختيار PolarBears Player Controller كأساس لحركة اللاعب.

### Tests
- التحقق من `dotnet --list-sdks`: يعرض 8.0.428 و 11.0.100.

### Known Issues
- لم يتم إنشاء مشاريع Godot بعد (المهمة 0.3).

### Fixed
- حذف مجلد `client/fps.client/` المكرر (بقايا إنشاء مشروع Godot الأول قبل نقل الملفات يدوياً). الملف المرجعي هو `client/FPS.Client.csproj` في جذر المشروع.

### Added
- استيراد PolarBears Player Controller إلى `client/addons/player_controller`.
- إعداد Input Map للحركة (WASD + Space + Ctrl + Shift).
- إنشاء `client/scenes/TestMap.tscn` (أرضية وجدار وإضاءة بسيطة).
- اختبار الحركة محلياً بنجاح.