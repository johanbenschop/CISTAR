namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EveStaticDataModel : DbContext
    {
        public EveStaticDataModel()
            : base("name=EveStaticDataModelConnection")
        {
        }

        public virtual DbSet<agtAgent> agtAgents { get; set; }
        public virtual DbSet<agtAgentType> agtAgentTypes { get; set; }
        public virtual DbSet<chrAncestry> chrAncestries { get; set; }
        public virtual DbSet<chrAttribute> chrAttributes { get; set; }
        public virtual DbSet<chrBloodline> chrBloodlines { get; set; }
        public virtual DbSet<chrFaction> chrFactions { get; set; }
        public virtual DbSet<chrRace> chrRaces { get; set; }
        public virtual DbSet<crpActivity> crpActivities { get; set; }
        public virtual DbSet<crpNPCCorporationDivision> crpNPCCorporationDivisions { get; set; }
        public virtual DbSet<crpNPCCorporation> crpNPCCorporations { get; set; }
        public virtual DbSet<crpNPCDivision> crpNPCDivisions { get; set; }
        public virtual DbSet<crtCertificate> crtCertificates { get; set; }
        public virtual DbSet<crtClass> crtClasses { get; set; }
        public virtual DbSet<crtRecommendation> crtRecommendations { get; set; }
        public virtual DbSet<crtRelationship> crtRelationships { get; set; }
        public virtual DbSet<dgmAttributeCategory> dgmAttributeCategories { get; set; }
        public virtual DbSet<dgmAttributeType> dgmAttributeTypes { get; set; }
        public virtual DbSet<dgmEffect> dgmEffects { get; set; }
        public virtual DbSet<dgmMastery> dgmMasteries { get; set; }
        public virtual DbSet<dgmTrait> dgmTraits { get; set; }
        public virtual DbSet<dgmTypeAttribute> dgmTypeAttributes { get; set; }
        public virtual DbSet<dgmTypeEffect> dgmTypeEffects { get; set; }
        public virtual DbSet<dgmTypeMastery> dgmTypeMasteries { get; set; }
        public virtual DbSet<dgmTypeTrait> dgmTypeTraits { get; set; }
        public virtual DbSet<eveGraphic> eveGraphics { get; set; }
        public virtual DbSet<eveIcon> eveIcons { get; set; }
        public virtual DbSet<eveUnit> eveUnits { get; set; }
        public virtual DbSet<invBlueprintType> invBlueprintTypes { get; set; }
        public virtual DbSet<invCategory> invCategories { get; set; }
        public virtual DbSet<invContrabandType> invContrabandTypes { get; set; }
        public virtual DbSet<invControlTowerResourcePurpos> invControlTowerResourcePurposes { get; set; }
        public virtual DbSet<invControlTowerResource> invControlTowerResources { get; set; }
        public virtual DbSet<invFlag> invFlags { get; set; }
        public virtual DbSet<invGroup> invGroups { get; set; }
        public virtual DbSet<invItem> invItems { get; set; }
        public virtual DbSet<invMarketGroup> invMarketGroups { get; set; }
        public virtual DbSet<invMetaGroup> invMetaGroups { get; set; }
        public virtual DbSet<invMetaType> invMetaTypes { get; set; }
        public virtual DbSet<invName> invNames { get; set; }
        public virtual DbSet<invPosition> invPositions { get; set; }
        public virtual DbSet<invTypeMaterial> invTypeMaterials { get; set; }
        public virtual DbSet<invTypeReaction> invTypeReactions { get; set; }
        public virtual DbSet<invType> invTypes { get; set; }
        public virtual DbSet<invUniqueName> invUniqueNames { get; set; }
        public virtual DbSet<mapCelestialStatistic> mapCelestialStatistics { get; set; }
        public virtual DbSet<mapConstellationJump> mapConstellationJumps { get; set; }
        public virtual DbSet<mapConstellation> mapConstellations { get; set; }
        public virtual DbSet<mapDenormalize> mapDenormalizes { get; set; }
        public virtual DbSet<mapJump> mapJumps { get; set; }
        public virtual DbSet<mapLandmark> mapLandmarks { get; set; }
        public virtual DbSet<mapLocationScene> mapLocationScenes { get; set; }
        public virtual DbSet<mapLocationWormholeClass> mapLocationWormholeClasses { get; set; }
        public virtual DbSet<mapRegionJump> mapRegionJumps { get; set; }
        public virtual DbSet<Region> mapRegions { get; set; }
        public virtual DbSet<mapSolarSystemJump> mapSolarSystemJumps { get; set; }
        public virtual DbSet<mapSolarSystem> mapSolarSystems { get; set; }
        public virtual DbSet<mapUniverse> mapUniverses { get; set; }
        public virtual DbSet<planetSchematic> planetSchematics { get; set; }
        public virtual DbSet<planetSchematicsPinMap> planetSchematicsPinMaps { get; set; }
        public virtual DbSet<planetSchematicsTypeMap> planetSchematicsTypeMaps { get; set; }
        public virtual DbSet<ramActivity> ramActivities { get; set; }
        public virtual DbSet<ramAssemblyLine> ramAssemblyLines { get; set; }
        public virtual DbSet<ramAssemblyLineStation> ramAssemblyLineStations { get; set; }
        public virtual DbSet<ramAssemblyLineTypeDetailPerCategory> ramAssemblyLineTypeDetailPerCategories { get; set; }
        public virtual DbSet<ramAssemblyLineTypeDetailPerGroup> ramAssemblyLineTypeDetailPerGroups { get; set; }
        public virtual DbSet<ramAssemblyLineType> ramAssemblyLineTypes { get; set; }
        public virtual DbSet<ramInstallationTypeContent> ramInstallationTypeContents { get; set; }
        public virtual DbSet<ramTypeRequirement> ramTypeRequirements { get; set; }
        public virtual DbSet<staOperation> staOperations { get; set; }
        public virtual DbSet<staOperationService> staOperationServices { get; set; }
        public virtual DbSet<staService> staServices { get; set; }
        public virtual DbSet<staStation> staStations { get; set; }
        public virtual DbSet<staStationType> staStationTypes { get; set; }
        public virtual DbSet<translationTable> translationTables { get; set; }
        public virtual DbSet<trnTranslationColumn> trnTranslationColumns { get; set; }
        public virtual DbSet<trnTranslationLanguage> trnTranslationLanguages { get; set; }
        public virtual DbSet<trnTranslation> trnTranslations { get; set; }
        public virtual DbSet<warCombatZone> warCombatZones { get; set; }
        public virtual DbSet<warCombatZoneSystem> warCombatZoneSystems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agtAgent>()
                .HasMany(e => e.invTypes)
                .WithMany(e => e.agtAgents)
                .Map(m => m.ToTable("agtResearchAgents").MapLeftKey("agentID").MapRightKey("typeID"));

            modelBuilder.Entity<agtAgentType>()
                .Property(e => e.agentType)
                .IsUnicode(false);

            modelBuilder.Entity<chrAttribute>()
                .Property(e => e.attributeName)
                .IsUnicode(false);

            modelBuilder.Entity<chrAttribute>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<chrFaction>()
                .Property(e => e.factionName)
                .IsUnicode(false);

            modelBuilder.Entity<chrFaction>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<chrRace>()
                .Property(e => e.raceName)
                .IsUnicode(false);

            modelBuilder.Entity<chrRace>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<chrRace>()
                .Property(e => e.shortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<crpNPCCorporation>()
                .Property(e => e.size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<crpNPCCorporation>()
                .Property(e => e.extent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.chrFactions)
                .WithOptional(e => e.crpNPCCorporation)
                .HasForeignKey(e => e.corporationID);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.chrFactions1)
                .WithOptional(e => e.crpNPCCorporation1)
                .HasForeignKey(e => e.militiaCorporationID);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporationDivisions)
                .WithRequired(e => e.crpNPCCorporation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations1)
                .WithOptional(e => e.crpNPCCorporation1)
                .HasForeignKey(e => e.enemyID);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations11)
                .WithOptional(e => e.crpNPCCorporation2)
                .HasForeignKey(e => e.friendID);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations12)
                .WithOptional(e => e.crpNPCCorporation3)
                .HasForeignKey(e => e.investorID1);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations13)
                .WithOptional(e => e.crpNPCCorporation4)
                .HasForeignKey(e => e.investorID2);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations14)
                .WithOptional(e => e.crpNPCCorporation5)
                .HasForeignKey(e => e.investorID3);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.crpNPCCorporations15)
                .WithOptional(e => e.crpNPCCorporation6)
                .HasForeignKey(e => e.investorID4);

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.invTypes)
                .WithMany(e => e.crpNPCCorporations)
                .Map(m => m.ToTable("crpNPCCorporationResearchFields").MapLeftKey("corporationID").MapRightKey("skillID"));

            modelBuilder.Entity<crpNPCCorporation>()
                .HasMany(e => e.invTypes1)
                .WithMany(e => e.crpNPCCorporations1)
                .Map(m => m.ToTable("crpNPCCorporationTrades").MapLeftKey("corporationID").MapRightKey("typeID"));

            modelBuilder.Entity<crpNPCDivision>()
                .HasMany(e => e.crpNPCCorporationDivisions)
                .WithRequired(e => e.crpNPCDivision)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dgmAttributeType>()
                .Property(e => e.attributeName)
                .IsUnicode(false);

            modelBuilder.Entity<dgmAttributeType>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<dgmAttributeType>()
                .Property(e => e.displayName)
                .IsUnicode(false);

            modelBuilder.Entity<dgmEffect>()
                .Property(e => e.effectName)
                .IsUnicode(false);

            modelBuilder.Entity<dgmEffect>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<dgmEffect>()
                .Property(e => e.guid)
                .IsUnicode(false);

            modelBuilder.Entity<dgmEffect>()
                .Property(e => e.displayName)
                .IsUnicode(false);

            modelBuilder.Entity<dgmEffect>()
                .Property(e => e.sfxName)
                .IsUnicode(false);

            modelBuilder.Entity<eveGraphic>()
                .Property(e => e.graphicFile)
                .IsUnicode(false);

            modelBuilder.Entity<eveGraphic>()
                .Property(e => e.graphicType)
                .IsUnicode(false);

            modelBuilder.Entity<eveGraphic>()
                .Property(e => e.gfxRaceID)
                .IsUnicode(false);

            modelBuilder.Entity<eveGraphic>()
                .Property(e => e.colorScheme)
                .IsUnicode(false);

            modelBuilder.Entity<eveGraphic>()
                .Property(e => e.sofHullName)
                .IsUnicode(false);

            modelBuilder.Entity<eveIcon>()
                .Property(e => e.iconFile)
                .IsUnicode(false);

            modelBuilder.Entity<eveUnit>()
                .Property(e => e.unitName)
                .IsUnicode(false);

            modelBuilder.Entity<eveUnit>()
                .Property(e => e.displayName)
                .IsUnicode(false);

            modelBuilder.Entity<eveUnit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<invControlTowerResourcePurpos>()
                .Property(e => e.purposeText)
                .IsUnicode(false);

            modelBuilder.Entity<invFlag>()
                .Property(e => e.flagName)
                .IsUnicode(false);

            modelBuilder.Entity<invFlag>()
                .Property(e => e.flagText)
                .IsUnicode(false);

            modelBuilder.Entity<invItem>()
                .HasOptional(e => e.invUniqueName)
                .WithRequired(e => e.invItem);

            modelBuilder.Entity<invName>()
                .HasOptional(e => e.agtAgent)
                .WithRequired(e => e.invName);

            modelBuilder.Entity<invName>()
                .HasOptional(e => e.chrFaction)
                .WithRequired(e => e.invName);

            modelBuilder.Entity<invName>()
                .HasOptional(e => e.crpNPCCorporation)
                .WithRequired(e => e.invName);

            modelBuilder.Entity<invType>()
                .Property(e => e.basePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<invType>()
                .HasMany(e => e.chrBloodlines)
                .WithOptional(e => e.invType)
                .HasForeignKey(e => e.shipTypeID);

            modelBuilder.Entity<mapCelestialStatistic>()
                .Property(e => e.spectralClass)
                .IsUnicode(false);

            modelBuilder.Entity<mapLandmark>()
                .Property(e => e.landmarkName)
                .IsUnicode(false);

            modelBuilder.Entity<mapLandmark>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<mapSolarSystem>()
                .Property(e => e.securityClass)
                .IsUnicode(false);

            modelBuilder.Entity<mapUniverse>()
                .Property(e => e.universeName)
                .IsUnicode(false);

            modelBuilder.Entity<ramActivity>()
                .Property(e => e.iconNo)
                .IsUnicode(false);

            modelBuilder.Entity<trnTranslationLanguage>()
                .Property(e => e.languageID)
                .IsUnicode(false);

            modelBuilder.Entity<trnTranslation>()
                .Property(e => e.languageID)
                .IsUnicode(false);
        }
    }
}
