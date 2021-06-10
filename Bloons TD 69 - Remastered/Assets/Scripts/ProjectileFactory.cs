using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Reflection;

public static class ProjectileFactory 
{
    private static Dictionary<string, Type> projectilesByName;
    private static bool isInicialized => projectilesByName != null;

    private static void InitializeFactory()
    {
        if (isInicialized)
        {
            return;
        }

        var projectileTypes = Assembly.GetAssembly(typeof(Projectile)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Projectile)));

        projectilesByName = new Dictionary<string, Type>();

        foreach(var type in projectileTypes)
        {
            var tempProj = Activator.CreateInstance(type) as Projectile;
            projectilesByName.Add(tempProj.Name, type);
        }
    }

    public static Projectile GetProjectile(string projectileType)
    {
        InitializeFactory();

        if (projectilesByName.ContainsKey(projectileType))
        {
            Type type = projectilesByName[projectileType];
            var projectile = Activator.CreateInstance(type) as Projectile;
            return projectile;
        }

        return null;
    }

    internal static IEnumerable<string> GetProjectileNames()
    {
        InitializeFactory();
        return projectilesByName.Keys;
    }




}
