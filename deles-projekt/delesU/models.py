from random import choices
from django.db import models
from delesE.models import Profil
from ckeditor.fields import RichTextField



class Kategoria(models.Model):
    class Meta:
        verbose_name = "Kategória"
        verbose_name_plural = "Kategóriák"
    
    nev = models.CharField('név', max_length=255)
    slug = models.SlugField(max_length=100)

    def __str__(self) -> str:
        return self.nev

class Cikk(models.Model):
    class Meta:
        verbose_name = 'Cikk'
        verbose_name_plural = 'Cikkek'

    ALKAT = {
        ('legfontosabb','Legfontosabb'),
        ('fontos','Fontos'),
        ('friss','Friss'),
    }

    cim = models.CharField('cím', max_length=255)
    id = models.CharField('id', max_length=255, primary_key=True)
    szerzo = models.ForeignKey(Profil, on_delete=models.CASCADE)
    rovtartalom = models.CharField('rövtartalom', max_length=510)
    tartalom = RichTextField('tartalom')
    kategoria = models.ForeignKey(Kategoria, on_delete= models.CASCADE, blank=True, null=True)
    datum = models.DateField('dátum', auto_now_add=True)

    alkat1 = models.CharField('alkategória 1', max_length=20, choices= ALKAT, blank=True)
    alkat2 = models.CharField('alkategória 2', max_length=20, choices= ALKAT, blank=True)
    alkat3 = models.CharField('alkategória 3', max_length=20, choices= ALKAT, blank=True)

    def __str__(self) -> str:
        return self.cim
