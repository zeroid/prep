configs ={
  :git => {
    :provider => "github",
    :user => "trimbleapril2014",
    :remotes => %w/zeroid satheeshkumardevadasan shaun1527 adonohu gebben Polydeuces mrossli hagerde/,
    :repo => 'prep' 
  }
}
configatron.configure_from_hash(configs)
