# Generated by Django 4.0.3 on 2022-05-12 09:33

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('delesE', '0004_remove_edcikk_szerzo_alter_profil_user'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='profil',
            name='pozicio',
        ),
        migrations.AddField(
            model_name='profil',
            name='pozicio',
            field=models.ManyToManyField(to='delesE.pozicio'),
        ),
        migrations.AlterField(
            model_name='profil',
            name='tagozat',
            field=models.ForeignKey(blank=True, on_delete=django.db.models.deletion.CASCADE, to='delesE.tagozat'),
        ),
    ]