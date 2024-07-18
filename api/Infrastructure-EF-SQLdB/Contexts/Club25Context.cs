using System.Reflection;
using Club25_Domain.Agregates.BandAgregate.Entities;
using Club25_Domain.Agregates.ClientAgregate;
using Club25_Domain.Agregates.ClientAgregate.Entities;
using Club25_Domain.Agregates.EventAgregate;
using Club25_Domain.Agregates.EventAgregate.Entities;
using Club25_Domain.Agregates.SponsorAgregate;
using Club25_Domain.Agregates.SponsorAgregate.Entities;
using Club25_Domain.Agregates.TagAgregate;
using Club25_Domain.Agregates.TicketPoolAgregate;
using Club25_Domain.Agregates.TicketPoolAgregate.Entities;
using Club25_Domain.Agregates.UserAgregate;
using Club25_Domain.Agregates.UserAgregate.Entities;
using Club25_Domain.Agregates.VenueAgregate;
using Club25_Domain.Agregates.VenueAgregate.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure_EF_SQLdB.Contexts;

public partial class Club25Context : DbContext
{
	public Club25Context()
	{
	}

	public Club25Context(DbContextOptions<Club25Context> options)
		: base(options)
	{
	}

	public virtual DbSet<Artist> Artists { get; set; }

	public virtual DbSet<ArtistDescription> ArtistDescriptions { get; set; }

	public virtual DbSet<Client> Clients { get; set; }

	public virtual DbSet<Culture> Cultures { get; set; }

	public virtual DbSet<Currency> Currencies { get; set; }

	public virtual DbSet<Event> Events { get; set; }

	public virtual DbSet<EventArtist> EventArtists { get; set; }

	public virtual DbSet<EventDescription> EventDescriptions { get; set; }

	public virtual DbSet<EventMediaPartner> EventMediaPartners { get; set; }

	public virtual DbSet<EventSponsor> EventSponsors { get; set; }

	public virtual DbSet<EventTag> EventTags { get; set; }

	public virtual DbSet<FeaturedEvent> FeaturedEvents { get; set; }

	public virtual DbSet<Language> Languages { get; set; }

	public virtual DbSet<Lineup> Lineups { get; set; }

	public virtual DbSet<MainSponsor> MainSponsors { get; set; }

	public virtual DbSet<Permission> Permissions { get; set; }

	public virtual DbSet<Person> People { get; set; }

	public virtual DbSet<Policy> Policies { get; set; }

	public virtual DbSet<Price> Prices { get; set; }

	public virtual DbSet<Sponsor> Sponsors { get; set; }

	public virtual DbSet<Stage> Stages { get; set; }

	public virtual DbSet<Tag> Tags { get; set; }

	public virtual DbSet<Ticket> Tickets { get; set; }

	public virtual DbSet<TicketMediaType> TicketMediaTypes { get; set; }

	public virtual DbSet<TicketPool> TicketPools { get; set; }

	public virtual DbSet<TicketType> TicketTypes { get; set; }

	public virtual DbSet<User> Users { get; set; }

	public virtual DbSet<UserGroup> UserGroups { get; set; }

	public virtual DbSet<Vendor> Vendors { get; set; }

	public virtual DbSet<Venue> Venues { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer(
			"Data Source=HOFFMAN;Initial Catalog=Club25;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

	protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}