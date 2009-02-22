class Concern

  attr_accessor :name, :contexts

  def initialize(concern_name)
    @name = concern_name
    @contexts = []
  end

end

