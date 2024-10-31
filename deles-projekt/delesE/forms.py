from django import forms

from .models import EdCikk

class UjEdCikkForm(forms.ModelForm):
    class Meta:
        model = EdCikk
        fields = [
            'cim',
            'dokumentum',
            'kategoria',
            'megjegyzes',
        ]