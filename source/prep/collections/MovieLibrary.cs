using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies as IEnumerable<Movie>;
    }

    public void add(Movie movie)
    {
      foreach (Movie ExistingMovie in all_movies())
      {
        if (ExistingMovie.title.Equals(movie.title))
          return;
      }
        this.movies.Add(movie);
    }
    
    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.production_studio.Equals(ProductionStudio.Pixar))
        retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.production_studio.Equals(ProductionStudio.Pixar) || movie.production_studio.Equals(ProductionStudio.Disney))
          retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (!movie.production_studio.Equals(ProductionStudio.Pixar))
          retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.date_published.Year > year)
          retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
          retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.genre.Equals(Genre.kids))
          retVar.Add(movie);
      }

      return retVar;
    }

    public IEnumerable<Movie> all_action_movies()
    {
      List<Movie> retVar = new List<Movie>();
      foreach (Movie movie in this.movies)
      {
        if (movie.genre.Equals(Genre.action))
          retVar.Add(movie);
      }

      return retVar;
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
