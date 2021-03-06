﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MegaMek_Scenario_Generator.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Vacuum, Trace, Thin, Standard, High, Very High.
        '''</summary>
        Friend ReadOnly Property Atmospheres() As String
            Get
                Return ResourceManager.GetString("Atmospheres", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Tilted, Not Tilted, Circular, Elliptical.
        '''</summary>
        Friend ReadOnly Property AxisOrbit() As String
            Get
                Return ResourceManager.GetString("AxisOrbit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property background() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("background", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property buttonNormal() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("buttonNormal", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extraction Raid, Target Defend, Target Raid, Location Defend, Capture Raid.
        '''</summary>
        Friend ReadOnly Property civilScenarios() As String
            Get
                Return ResourceManager.GetString("civilScenarios", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Arctic, Temperate, Tropical.
        '''</summary>
        Friend ReadOnly Property Climates() As String
            Get
                Return ResourceManager.GetString("Climates", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Flats, Hills, Cliffs, Mountain.
        '''</summary>
        Friend ReadOnly Property Elevations() As String
            Get
                Return ResourceManager.GetString("Elevations", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Inner Sphere, Clan.
        '''</summary>
        Friend ReadOnly Property Factions() As String
            Get
                Return ResourceManager.GetString("Factions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Plains, Woodland, Forest, Urban.
        '''</summary>
        Friend ReadOnly Property Features() As String
            Get
                Return ResourceManager.GetString("Features", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to None, Light Fog, Heavy Fog.
        '''</summary>
        Friend ReadOnly Property Fog() As String
            Get
                Return ResourceManager.GetString("Fog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Mission, Scenario, Intensity, Objective, Faction, Size, Rating, Start, Special, Commanding Officer, Senior Enlisted Advisor, Executive Officer, Operations Chief, Support, Planet, Axis/Orbit, Season, Moons, Gravity, Atmosphere, EQ Temp, Surface Water, Latitude, Longitude, Theme, Terrain, Temp, Light, Weather, Wind, Blowing Sand, Fog, EMI, Map Size.
        '''</summary>
        Friend ReadOnly Property Labels() As String
            Get
                Return ResourceManager.GetString("Labels", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to South, North, Equator.
        '''</summary>
        Friend ReadOnly Property Latitudes() As String
            Get
                Return ResourceManager.GetString("Latitudes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblDGLG() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblDGLG", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblDRLR() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblDRLR", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblLGDG() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblLGDG", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblLRDR() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblLRDR", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblOY() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblOY", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lblYO() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lblYO", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Daylight, Dusk/Dawn, Full Moon Night, Moonless Night.
        '''</summary>
        Friend ReadOnly Property Light() As String
            Get
                Return ResourceManager.GetString("Light", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to West, East, Prime Meridian.
        '''</summary>
        Friend ReadOnly Property Longitudes() As String
            Get
                Return ResourceManager.GetString("Longitudes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property megamek() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("megamek", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error Mismatch, None, Yes, No.
        '''</summary>
        Friend ReadOnly Property Misc() As String
            Get
                Return ResourceManager.GetString("Misc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Guerrilla, Diversionary Raid, Extraction Raid, Objective Raid, Recon Raid, Planetary Assault, Relief Duty, Security Duty, Pirate Hunting, Riot Duty, Garrison Duty, Cadre Duty, Planetary Entry.
        '''</summary>
        Friend ReadOnly Property Missions() As String
            Get
                Return ResourceManager.GetString("Missions", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Destroy OPFOR, Destroy Defenders, Destroy Attackers, Politician, Corporate President, Base Commander, Supply Caches, Turrets, Commander&apos;s Convoy, Supply Convoy, Military Reinforcements, High Value Personnel, Allied Military Unit, Politician&apos;s Convoy, Prisoners of War, Ammo Caches, Weapon Caches, Land and Defend Dropship(s), Flee Off Opposite Map Edge.
        '''</summary>
        Friend ReadOnly Property Objectives() As String
            Get
                Return ResourceManager.GetString("Objectives", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Clear, Light Rain, Moderate Rain, Heavy Rain, Gusting Rain, Torrential Downpour.
        '''</summary>
        Friend ReadOnly Property Rain() As String
            Get
                Return ResourceManager.GetString("Rain", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to F, D, C, B, A.
        '''</summary>
        Friend ReadOnly Property Rating() As String
            Get
                Return ResourceManager.GetString("Rating", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Extraction Raid, Capture Intercept, Target Escort, Target Intercept, Target Defend, Target Raid, Location Defend, Capture Raid, Patrol, Search &amp; Destroy, Cadre Duty, Uncontested Landing, Assault Drop, Low Atmosphere Battle, Space Battle.
        '''</summary>
        Friend ReadOnly Property Scenarios() As String
            Get
                Return ResourceManager.GetString("Scenarios", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Spring, Fall, Summer, Winter.
        '''</summary>
        Friend ReadOnly Property Seasons() As String
            Get
                Return ResourceManager.GetString("Seasons", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Star, Binary, Nova, Trinary, 2 Trinaries, Cluster, 2 Clusters, Galaxy.
        '''</summary>
        Friend ReadOnly Property sizeClan() As String
            Get
                Return ResourceManager.GetString("sizeClan", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Lance, 2 Lances, Company, 2 Companies, Battalion, 2 Battalions, Regiment.
        '''</summary>
        Friend ReadOnly Property sizeInnerSphere() As String
            Get
                Return ResourceManager.GetString("sizeInnerSphere", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Clear, Light Snow Fall, Moderate Snow Fall, Sleet, Snow Flurries, Heavy Snow Fall, Ice Storm, Blizzard.
        '''</summary>
        Friend ReadOnly Property Snow() As String
            Get
                Return ResourceManager.GetString("Snow", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Planet Arrival,  And Then Withdraw,  Escort to Opposite Map Edge, 1/3 .
        '''</summary>
        Friend ReadOnly Property Special() As String
            Get
                Return ResourceManager.GetString("Special", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to NW, N, NE, W, CTR, E, SW, S, SE, Edge.
        '''</summary>
        Friend ReadOnly Property startLocations() As String
            Get
                Return ResourceManager.GetString("startLocations", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to grass, tropical, snow, volcano, lunar, mars, space.
        '''</summary>
        Friend ReadOnly Property Themes() As String
            Get
                Return ResourceManager.GetString("Themes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Residential, Industrial, Military Base.
        '''</summary>
        Friend ReadOnly Property typeCivilization() As String
            Get
                Return ResourceManager.GetString("typeCivilization", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Personnel, Supply, Military.
        '''</summary>
        Friend ReadOnly Property typeObjective() As String
            Get
                Return ResourceManager.GetString("typeObjective", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Calm, Light Gale, Moderate Gale, Strong Gale, Storm, Tornado F1-F3, Tornado F4+.
        '''</summary>
        Friend ReadOnly Property Wind() As String
            Get
                Return ResourceManager.GetString("Wind", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
