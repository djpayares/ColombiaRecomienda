using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMapaColombia.Data
{
	public class RestaurantService
	{
		private readonly List<Restaurant> _restaurants = new List<Restaurant>
		{
            // Restaurantes en Bogotá
            new Restaurant {
				Id = 1,
				Name = "Andrés Carne de Res",
				Type = "Colombiano",
				Description = "Famoso restaurante con ambiente festivo",
				Address = "Calle 82 #12-21",
				Rating = 4.8,
				CityId = 1,
				ImageUrl = "https://example.com/andres-carne-de-res.jpg",
				SocialMediaLink = "https://www.instagram.com/andrescarnederes/"
			},
			new Restaurant {
				Id = 2,
				Name = "Harry Sasson",
				Type = "Gourmet",
				Description = "Alta cocina en una casa histórica",
				Address = "Carrera 9 #75-70",
				Rating = 4.7,
				CityId = 1,
				ImageUrl = "https://example.com/harry-sasson.jpg",
				SocialMediaLink = "https://www.instagram.com/harrysasson/"
			},
			new Restaurant {
				Id = 3,
				Name = "Salvo Patria",
				Type = "Cocina Contemporánea",
				Description = "Innovación gastronómica con ingredientes locales",
				Address = "Calle 55 #5-23",
				Rating = 4.9,
				CityId = 1,
				ImageUrl = "https://example.com/salvo-patria.jpg",
				SocialMediaLink = "https://www.instagram.com/salvopatria/"
			},
			new Restaurant {
				Id = 4,
				Name = "Criterion",
				Type = "Alta Cocina",
				Description = "Experiencia gastronómica de los hermanos Rausch",
				Address = "Calle 69A #5-75",
				Rating = 4.8,
				CityId = 1,
				ImageUrl = "https://example.com/criterion.jpg",
				SocialMediaLink = "https://www.instagram.com/criterionbogota/"
			},

            // Restaurantes en Medellín
            new Restaurant {
				Id = 5,
				Name = "El Cielo",
				Type = "Molecular",
				Description = "Experiencia gastronómica sensorial",
				Address = "Carrera 40 #10A-22",
				Rating = 4.6,
				CityId = 2,
				ImageUrl = "https://example.com/el-cielo-medellin.jpg",
				SocialMediaLink = "https://www.instagram.com/elcielorestaurante/"
			},
			new Restaurant {
				Id = 6,
				Name = "Herbario",
				Type = "Vegetariano",
				Description = "Cocina vegetariana creativa",
				Address = "Carrera 37 #8-43",
				Rating = 4.7,
				CityId = 2,
				ImageUrl = "https://example.com/herbario-medellin.jpg",
				SocialMediaLink = "https://www.instagram.com/herbariomedellin/"
			},
			new Restaurant {
				Id = 7,
				Name = "Alambique",
				Type = "Cocina Colombiana",
				Description = "Platos tradicionales con toque contemporáneo",
				Address = "Calle 9 #37-53",
				Rating = 4.6,
				CityId = 2,
				ImageUrl = "https://example.com/alambique-medellin.jpg",
				SocialMediaLink = "https://www.instagram.com/alambiquerestaurante/"
			},
			new Restaurant {
				Id = 8,
				Name = "OCI.Mde",
				Type = "Contemporáneo",
				Description = "Cocina creativa con productos locales",
				Address = "Carrera 36 #10A-27",
				Rating = 4.8,
				CityId = 2,
				ImageUrl = "https://example.com/oci-medellin.jpg",
				SocialMediaLink = "https://www.instagram.com/ocimedellin/"
			},

            // Restaurantes en Cali
            new Restaurant {
				Id = 9,
				Name = "Chugchucaré",
				Type = "Tradicional Valluno",
				Description = "Auténtica comida del Valle del Cauca",
				Address = "Avenida 9N #13-34",
				Rating = 4.7,
				CityId = 3,
				ImageUrl = "https://example.com/chugchucare-cali.jpg",
				SocialMediaLink = "https://www.instagram.com/chugchucare/"
			},
			new Restaurant {
				Id = 10,
				Name = "Lola",
				Type = "Cocina Fusión",
				Description = "Innovación culinaria con sabores locales",
				Address = "Calle 5 #38-53",
				Rating = 4.8,
				CityId = 3,
				ImageUrl = "https://example.com/lola-cali.jpg",
				SocialMediaLink = "https://www.instagram.com/lolacocina/"
			},
			new Restaurant {
				Id = 11,
				Name = "Mauricio Vélez",
				Type = "Gourmet",
				Description = "Cocina de autor con productos del Valle",
				Address = "Carrera 4 #7-33",
				Rating = 4.6,
				CityId = 3,
				ImageUrl = "https://example.com/mauricio-velez-cali.jpg",
				SocialMediaLink = "https://www.instagram.com/mauriciovelezrestaurante/"
			},

            // Restaurantes en Cartagena
            new Restaurant {
				Id = 12,
				Name = "1621",
				Type = "Contemporáneo",
				Description = "Cocina caribeña de alta gama",
				Address = "Centro Histórico",
				Rating = 4.9,
				CityId = 4,
				ImageUrl = "https://example.com/1621-cartagena.jpg",
				SocialMediaLink = "https://www.instagram.com/1621restaurante/"
			},
			new Restaurant {
				Id = 13,
				Name = "María",
				Type = "Fusión Caribeña",
				Description = "Sabores locales con técnicas internacionales",
				Address = "Calle del Colegio",
				Rating = 4.8,
				CityId = 4,
				ImageUrl = "https://example.com/maria-cartagena.jpg",
				SocialMediaLink = "https://www.instagram.com/mariarestaurante/"
			},
			new Restaurant {
				Id = 14,
				Name = "Celele",
				Type = "Cocina de Investigación",
				Description = "Exploración de ingredientes del Caribe colombiano",
				Address = "Calle de la Iglesia",
				Rating = 4.7,
				CityId = 4,
				ImageUrl = "https://example.com/celele-cartagena.jpg",
				SocialMediaLink = "https://www.instagram.com/celelerestaurante/"
			},

            // Restaurantes en Valledupar
            new Restaurant {
				Id = 15,
				Name = "Restaurante Quile",
				Type = "Restaurante, Patio Bar",
				Description = "Quile Delicias de Novillo en Valledupar",
				Address = "📍Cra 18D #22c-19 Avenida Simón Bolívar",
				Rating = 4.6,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9WwCZvEBbuE0on1EXShTayrZ8xcTbb2OyAw&s",
				SocialMediaLink = "https://www.instagram.com/quilevalledupar/?hl=es"
			},
			new Restaurant {
				Id = 16,
				Name = "Varadero Valledupar",
				Type = "Restaurante de marisco",
				Description = "25 años de Sabor, Música, Tradición y Guaguancó.",
				Address = "📍Cl. 12 #6 - 56",
				Rating = 4.5,
				CityId = 5,
				ImageUrl = "https://lh5.googleusercontent.com/p/AF1QipMTALBbuTj2UwmWvp7n4j1FxYORShwVpWMF4OrH=w260-h175-n-k-no",
				SocialMediaLink = "https://www.instagram.com/varaderovalledupar/?hl=es"
			},
			new Restaurant {
				Id = 17,
				Name = "Sr Brocheta",
				Type = "Comida rápida",
				Description = "Amantes de la calidad",
				Address = "📍Cl. 16 #19E - 85",
				Rating = 4.7,
				CityId = 5,
				ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipP5xpCiYbiKo-bFd-Xpa2ZToBJEtzT9Xq3RBQI=s680-w680-h510",
				SocialMediaLink = "https://www.instagram.com/sr.brocheta/?hl=es"
			},
			new Restaurant {
				Id = 18,
				Name = "Galeón 2•23",
				Type = "Restaurante & Bar",
				Description = "¡Alta cocina de vanguardia! 🌍",
				Address = "📍Carrera 9 #7b-18",
				Rating = 4.8,
				CityId = 5,
				ImageUrl = "https://elpilon.com.co/wp-content/uploads/2018/04/GALEON-SERGIO-MCGREEN-7.jpg",
				SocialMediaLink = "https://www.instagram.com/galeonrestobar?igsh=MTNsOXkwNWV0c25lbg=="
			},
			new Restaurant {
				Id = 19,
				Name = "El Rubí",
				Type = "Restaurante familiar",
				Description = "¡¡Explorando nuevos rincones y creando momentos inolvidables!",
				Address = "📍Cra. 9 #6-24",
				Rating = 4.0,
				CityId = 5,
				ImageUrl = "https://elpilon.com.co/wp-content/uploads/2023/06/el-rubi.png",
				SocialMediaLink = "https://www.instagram.com/elrubirestaurante"
			},
			new Restaurant {
				Id = 20,
				Name = "RESTAURANTE CATALEYA",
				Type = "Restaurante Bar",
				Description = "Comida italiana 🇮🇹",
				Address = "📍Cra 10 No. 11-18",
				Rating = 4.4,
				CityId = 5,
				ImageUrl = "https://img.restaurantguru.com/r53c-Cataleya-Restaurante-exterior.jpg",
				SocialMediaLink = "https://www.instagram.com/cataleya_restobar?igsh=Zzd0dHNtZHFpb2Ny"
			},
			new Restaurant {
				Id = 21,
				Name = "La Tagoretta",
				Type = "Cocina-Bar",
				Description = "Comida italiana 🇮🇹",
				Address = "Sede 1 📍Cra 19D #15a - 06, Las Flores vpa\r\n----Sede 2 📍calle 6c #9 - 76, Los Ángeles vpa",
				Rating = 4.8,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4V6OkmREx8F09sBrzJpiz0HfEmqMcG4kueg&s",
				SocialMediaLink = "https://www.instagram.com/la_tagoretta"
			},
			new Restaurant {
				Id = 22,
				Name = "LA MARTINA",
				Type = "Cocina-Bar",
				Description = "Gastronomía Fusión - MUSICA EN VIVO ! 12 M A ➡️ 3 PM & 6 PM ➡️",
				Address = "📍Cra 9 # 9 - 33",
				Rating = 4.8,
				CityId = 5,
				ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/04/26/de/la-martina-restobar.jpg?w=900&h=500&s=1",
				SocialMediaLink = "https://www.instagram.com/lamartinacb"
			},
			new Restaurant {
				Id = 23,
				Name = "ANKARA",
				Type = "COCINA FUSIÓN",
				Description = "Sabor, Creatividad, Pasión Y Magia",
				Address = "📍Cl. 3 #19-84",
				Rating = 4.1,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYM8r6xopRhXTvYXJAaTrDyc2ITAogOf_iHA&s",
				SocialMediaLink = "https://www.instagram.com/ankaracocinafusion"
			},
			new Restaurant {
				Id = 24,
				Name = "Pronto Pizza 🍕",
				Type = "Restaurante",
				Description = "Sabor, Creatividad, Pasión Y Magia",
				Address = "📍Cra 19D # 15-06 Las flores",
				Rating = 4.0,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjkGvrIQm8rrvb6jzv3tHhTdJNiPiV4HGcTQ&s",
				SocialMediaLink = "https://www.instagram.com/prontopizzavalle"
			},
			new Restaurant {
				Id = 25,
				Name = "Casa Belén",
				Type = "Restaurante",
				Description = "Cultura | Tradición",
				Address = "📍Cra 6 #13c-44",
				Rating = 4.8,
				CityId = 5,
				ImageUrl = "https://back.vinapp.co//store/1000x500370935-2023-02-09-10-57-41.jpg",
				SocialMediaLink = "https://www.instagram.com/casabelencocina"
			},
			new Restaurant {
				Id = 26,
				Name = "Vicente",
				Type = "Asiático I parrilla I Restaurante",
				Description = "Autenticidad y experiencia en cada bocado",
				Address = "📍Carrera 6 #12-05",
				Rating = 4.1,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTWqHQLaW2kZr07vkBWK1WAJjAoPNcMZhKWbA&s",
				SocialMediaLink = "https://www.instagram.com/vicente.vup"
			},
			new Restaurant {
				Id = 27,
				Name = "Amaretto cocina",
				Type = "Eventos | Comida | Sushi | Bar ✨",
				Description = "¡Un centro de entretenimiento con una gran propuesta gastronómica, cultural y de eventos! ✨",
				Address = "📍Cra 11 # 7D -38 San Carlos",
				Rating = 4.7,
				CityId = 5,
				ImageUrl = "https://cdn.semanariolacalle.com/2024/05/Amarretto-Cocina.jpg",
				SocialMediaLink = "https://www.instagram.com/amarettococinavup"
			},
			new Restaurant {
				Id = 28,
				Name = "Mi Nona Cafe",
				Type = "Restaurante - Café",
				Description = "Somos parte de ti",
				Address = "📍Calle 16 # 7-19",
				Rating = 4.9,
				CityId = 5,
				ImageUrl = "https://minonacafe.com/wp-content/uploads/2024/11/0012-1.jpg",
				SocialMediaLink = "https://www.instagram.com/minonacafe"
			},
			new Restaurant {
				Id = 29,
				Name = "Ｂｕｒｇｅｒ Ｆａｃｔｏｒｙ®",
				Type = "Restaurante",
				Description = "¡No respondemos por lo que pase después del primer mordisco!😎",
				Address = "📍🕋 ➧ Cra 9 # 10-15 Novalito\r\n🕋 ➧ Cra 19 # 7b-44 Músicos",
				Rating = 4.5,
				CityId = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmNWr6HlJjYV_fJsQh2ai90BqTaOIcNBTlXQ&s",
				SocialMediaLink = "https://www.instagram.com/the_burger_factory"
			}

		};

		public async Task<List<Restaurant>> GetRestaurantsByCityAsync(int cityId)
		{
			// Simulación de llamada asíncrona a una API o base de datos
			await Task.Delay(300);
			return _restaurants.Where(r => r.CityId == cityId).ToList();
		}
	}
}