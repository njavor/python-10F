from django.contrib import admin
from .models import Cikk, Kategoria

class CikkAdmin(admin.ModelAdmin):
    fieldsets = (
        ('Tartalom', {
            'fields': ('cim', 'id', 'szerzo', 'rovtartalom', 'tartalom', 'kategoria'),
        }),
        ('Alkategóriák', {
            'fields': ('alkat1', 'alkat2', 'alkat3'),
            'classes': ('collapse',),
        })
    )

admin.site.register(Cikk, CikkAdmin)
admin.site.register(Kategoria)