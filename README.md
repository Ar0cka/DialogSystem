# 🧠 Dialog Graph Editor for Unity (GraphView-based)

**Editor tool for managing branching dialog systems** using Unity’s GraphView API.  
Разрабатывалось как внутренняя тулза, завязанная на конкретную структуру проекта, но может быть адаптирована под любую систему диалогов с узлами и связями.

---

## 📦 Основные фичи

- Создание диалогов через граф узлов
- Редактирование текста, состояния и связей между узлами
- Сохранение/загрузка диалогов в `ScriptableObject`
- UI на базе `UIElements` + `GraphView`
- Простая возможность расширения и интеграции

---

## 📂 Структура проекта

| Компонент | Описание |
|----------|----------|
| `DialogGraphEditor.cs` | Главное окно редактора (EditorWindow + Toolbar) |
| `DialogNodeGraph.cs` | Основа графа (GraphView + логика связей) |
| `DialogNodeView.cs` | Представление одного узла в графе |
| `DialogNodeScrObj.cs` | `ScriptableObject`, хранящий сериализованные узлы |
| `DialogNodeDataForGraph.cs` | Структура данных одного узла |
| `MyEdgeCon.cs` | Кастомный `IEdgeConnectorListener` для создания связей |

---

## 🚀 Быстрый старт

### 1. Установка
Скачай или клонируй проект:
```bash
git clone https://github.com/Ar0cka/DialogSystem
```
2. Создание ScriptableObject
В Unity:
```sql
Assets > Create > DialogSystem > CreateDialogScrObj
```
3. Открытие редактора
```sql
CustomTools > Graph > Dialog Editor
```
4. Управление
    Create new dialog graph – создать новый узел
    Save – сохранить текущее состояние в выбранный DialogNodeScrObj
    Load – загрузить граф из DialogNodeScrObj
    Graph Asset – поле для указания объекта DialogNodeScrObj

📸 Скриншоты
     ![Interface Preview](./Assets/Visual.png)


🛠 Как адаптировать под свой проект
    Переопредели DialogNodeDataForGraph — добавь свои поля (условия, ивенты, ID и т.д.)
    Обнови DialogNodeView — чтобы UI отображал твои поля
    Измени SaveGraph и LoadGraph — учитывай, что сериализовать нужно твои поля
    Добавь кастомные состояния, фильтры, и т.д. — как часть Enum или ScriptableObject

⚠️ Важно
    Проект заточен под Unity Editor, UIElements, GraphView API
    Требуется Unity версии 2021.3+ или выше (в зависимости от стабильности GraphView)
    Не предназначено для выполнения во время рантайма

MIT License. Делай с этим всё что хочешь, но ссылку оставь :)
