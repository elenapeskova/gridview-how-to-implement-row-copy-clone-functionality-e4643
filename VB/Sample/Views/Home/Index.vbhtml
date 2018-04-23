@ModelType List(Of Sample.Models.Person)
<script type="text/javascript">
    var rowKeyValueToCopy;
    function OnBeginCallback(s, e) {
        if (e.command === "CUSTOMCALLBACK") {
            e.customArgs["key"] = rowKeyValueToCopy;
        }
    }
    function OnCustomButtonClick(s, e) {
        rowKeyValueToCopy = s.GetRowKey(e.visibleIndex);
        s.PerformCallback();
    }
</script>
@Html.Partial("GridViewEditingPartial", Model)