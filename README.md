# How-to-enlarge-the-button-size-of-WinForms-DateTimePickerAdv
The WinForms DateTimePickerAdv control does not have direct support to enlarge the Up/Down button size. But you can customize the Up/Down button size by adjusting the value of Font or Size properties. Refer the below code for your reference. 

# C#
    //Using Font property.
    dateTimePickerAdv.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

    //Using Size property.
    dateTimePickerAdv.Size = new Size(276, 50);

For more details please refer [How to enlarge button size in DateTimePickerAdv](https://www.syncfusion.com/kb/12020 how-to-enlarge-the-button-size-of-wf-datetimepickeradv).
