from xml.dom.minidom import Document
from django.db import models
from django.urls import reverse
from django.contrib.auth.models import User

class Tagozat(models.Model):
    class Meta:
        verbose_name = 'Tagozat'
        verbose_name_plural = 'Tagozatok'

    nev = models.CharField('név', max_length=255)
    betu = models.CharField('betűjel', max_length=1)

    def __str__(self) -> str:
        return self.nev + ' - ' + self.betu

class Pozicio(models.Model):
    class Meta:
        verbose_name = 'Pozíció'
        verbose_name_plural = 'Pozíciók'

    nev = models.CharField('név', max_length=255)
    
    def __str__(self) -> str:
        return self.nev

class Profil(models.Model):
    user = models.OneToOneField(User, on_delete = models.CASCADE)
    class Meta:
        verbose_name = 'Profil'
        verbose_name_plural = 'Profilok'


    class Evfolyamok(models.TextChoices):
        KNY = 'KNY','KNY'
        _9 = '9','9'
        _10 = '10', '10'
        _11 = '11', '11'
        _12 = '12', '12'

    profilkep = models.ImageField('profilkép', blank=True)
    tagozat = models.ForeignKey(Tagozat, on_delete = models.CASCADE, blank=True)
    evfolyam = models.CharField('évfolyam', max_length=3 , choices=Evfolyamok.choices, blank=True)
    pozicio = models.ManyToManyField(Pozicio)
    
    def __str__(self) -> str:
        return str(self.user) + ' | ' + self.tagozat.betu




class EdCikk(models.Model):
    class Meta:
        verbose_name = 'Publikálatlan cikk'
        verbose_name_plural = 'Publikálatlan cikkek'

    class Status(models.TextChoices):
        lektor = 'Lektorálás alatt', 'Lektorálás alatt'
        tordeles = 'Tördelés alatt', 'Tördelés alatt'
        vissza = 'Visszaküldve', 'Visszaküldve'
        public = 'Publikus', 'Publikus'


    cim = models.CharField('cím', max_length=255)
    dokumentum = models.FileField('dokumentum', upload_to='edcikk/dokumentumok/')
    kategoria = models.CharField('kategória', max_length=244)
    megjegyzes = models.CharField('megjegyzés', max_length=500, blank=True)
    statusz = models.CharField('státusz', max_length=20, choices=Status.choices, default= Status.lektor)
    
    def __str__(self) -> str:
        return self.cim + ' - ' + self.statusz
    
    def get_absolute_url(self):
        return reverse('szerkesztoseg')