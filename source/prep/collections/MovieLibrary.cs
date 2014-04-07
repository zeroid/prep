using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    private List<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = new List<Movie>(list_of_movies);
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies.ToArray();
    }

    public void add(Movie movie)
    {
        if (!movies.Contains(movie))
        {
          movies.Add(movie);
        }
    }

    public IEnumerable<Movie> all_movies_published_by(ProductionStudio productionStudio)
    {
        return movies.FindAll(a => a.production_studio.Equals(productionStudio)).ToArray();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
        return all_movies_published_by(ProductionStudio.Pixar);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
        var result = new List<Movie>();
        result.AddRange(all_movies_published_by(ProductionStudio.Pixar));
        result.AddRange(all_movies_published_by(ProductionStudio.Disney));
       return result.ToArray();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
        return movies.FindAll(a => !a.production_studio.Equals(ProductionStudio.Pixar)).ToArray();
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
        return movies.FindAll(a => a.date_published > new DateTime(year, 1, 1)).ToArray();
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
        return movies.FindAll(a => a.date_published >= new DateTime(startingYear, 1, 1) && a.date_published < new DateTime(endingYear, 12, 31)).ToArray();
    }

    public IEnumerable<Movie> all_kid_movies()
    {
       return movies.FindAll(a => a.genre.Equals(Genre.kids));
    }

    public IEnumerable<Movie> all_action_movies()
    {
      return movies.FindAll(a => a.genre.Equals(Genre.action));
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
