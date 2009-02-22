require "spec"
require "../concern"

describe "When Initializing" do

  concern = Concern.new "Test"

  it "should set its name" do
    #To change this template use File | Settings | File Templates.
    concern.name.should == "Test"
  end


end