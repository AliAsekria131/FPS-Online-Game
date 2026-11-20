# FPS Online Game

لعبة تصويب جماعية عبر الإنترنت من منظور الشخص الأول، مبنية بـ Godot 4.7 .NET و C#.

## المتطلبات

- Godot 4.7.2 .NET (Mono) — [تحميل](https://godotengine.org/download/archive/)
- .NET 8 SDK — [تحميل](https://dotnet.microsoft.com/download/dotnet/8.0)

## هيكل المشروع

| المجلد | الوصف |
|---|---|
| `shared/` | مكتبة C# مشتركة (ثوابت، نماذج حالة، تعريفات الشبكة) |
| `client/` | مشروع Godot للعميل (العرض، الإدخال، واجهة المستخدم) |
| `server/` | مشروع Godot للخادم (منطق اللعبة، التحقق، الحالة) |

## تشغيل المشروع

### العميل
1. افتح `client/project.godot` في Godot.
2. اضغط F5 لتشغيل المشهد الرئيسي.

### الخادم
1. افتح `server/project.godot` في Godot (أو شغّله headless).
2. راجع `server/scripts/ServerMain.cs` لإعدادات المنفذ.

## التوثيق

- [PROJECT_STATE.md](PROJECT_STATE.md) — الحالة الفعلية للمشروع
- [ARCHITECTURE.md](ARCHITECTURE.md) — البنية المعمارية
- [CHANGELOG.md](CHANGELOG.md) — سجل التغييرات
- [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md) — المصادر الخارجية والتراخيص

## الترخيص

سيُحدد لاحقاً.