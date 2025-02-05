# Generated by Django 4.0.3 on 2022-04-18 16:28

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('delesE', '0002_alter_edcikk_dokumentum_alter_edcikk_statusz'),
    ]

    operations = [
        migrations.AddField(
            model_name='edcikk',
            name='szerzo',
            field=models.ForeignKey(null=True, on_delete=django.db.models.deletion.SET_NULL, to='delesE.profil'),
        ),
        migrations.AlterField(
            model_name='edcikk',
            name='dokumentum',
            field=models.FileField(upload_to='edcikk/dokumentumok/', verbose_name='dokumentum'),
        ),
    ]
